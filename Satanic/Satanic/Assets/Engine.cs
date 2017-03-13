using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public enum ArtifactID { DragonSkull }

public enum HouseID { Alpha, Beta, Delta, Gamma, Zeta, None }

public class NobleHouse
{
    string name;
    HouseID id;
    int playerReputation;
}

public class Engine : MonoBehaviour
{
    public static int currentDay = 0;
    public const int daysInWeek = 7;
    public const float jobMatchesHeroEffectChance = 0.3f;
    public const float jobMatchesHeroTierChance = 0.3f;
    const int minimumPrestigeGuaranteedJobEffect = 1;
    
    public static Player Hero;

    
    public static List<Citizen> AllPatrons;
    public static List<Job> PendingJobs;
    public static List<Job> AcceptedJobs;
    public static List<Job> RejectedJobs;
    public static List<Job> DeferredJobs;
    public static List<Job> SucceededJobs;
    public static List<Job> FailedJobs;

    public static Spell currentSpell;
    public static Job currentJob;
    public static Market currentMarket;
   

    public static Engine Main;
    
    public static bool hasActionsRemaining;

    //static WeightedCollection<Job> RandomJobs;




    public static void NewDay()
    {
        currentDay++;
        hasActionsRemaining = true;


        //Update the store prices
        foreach(KeyValuePair<MarketID, Market> entry in Market.Definitions)
        {
            entry.Value.DailyUpdateStore();
        }


        DeferAndFailJobs();
        GetJobs();
        
        //Select a new job if there's nothing selected
        AutoSelectJobIfNull();
        AutoSelectSpellIfNull();


        CheckEvents();


        //Refresh Page
        LayoutManager.Main.DailyDisplayRoutine();

    }

    static void DeferAndFailJobs()
    {
        //Defer all pending jobs from yesterday you haven't accepted
        foreach (Job job in PendingJobs.ToArray())
        {
            PendingJobs.Remove(job);
            DeferredJobs.Add(job);
            DeselectJobIfCurrent(job);
        }

        //Fail accepted jobs that have passed the deadline
        foreach (Job job in AcceptedJobs.ToArray())
        {
            job.remainingTimeToComplete--;
            if (job.remainingTimeToComplete <= 0)
                FailJob(job);
        }
    }

    static void GetJobs()
    {
        int targetTier = Hero.Tier;

        int minNewJobs = 0;
        int maxNewJobs = 3;
        if (AcceptedJobs.Count <= 1)
            minNewJobs = 1;

        if (Hero.Tier == 1)
        {
            maxNewJobs = 2;
            if (Hero.prestige == 0)
                maxNewJobs = 1;
        }




        Job.AllRandomJobs.AddRange(DeferredJobs); //dump all deferred jobs into the greater pool
        DeferredJobs.Clear();
        Job.AllRandomJobs.Shuffle();
        for (int i = 0; i < Random.Range(minNewJobs, maxNewJobs+1); i++)
        {
            bool guaranteedApplicability = Random.Range(0, 1f) < jobMatchesHeroEffectChance || Hero.prestige < minimumPrestigeGuaranteedJobEffect; //otherwise will not necissarily be applicable to your current skills
            bool guaranteedEqualTier = Random.Range(0, 1f) < jobMatchesHeroTierChance; //otherwise can search below

            //First try new jobs of my level or lower
            var query = SearchJobs(Job.AllRandomJobs, guaranteedApplicability, guaranteedEqualTier);
            if (query.Count() == 0)
                query = SearchJobs(Job.AllRandomJobs, false, false);
            if (query.Count() > 0)
            {
                Job chosenJob = query.First();
                Job.AllRandomJobs.Remove(chosenJob);
                AddPendingJob(chosenJob);
                continue;
            }

            //this throws any unassigned job at the player, not ideal, we should be searching in an increasing radius from the hero's prestige
            if (Job.AllRandomJobs.Count > 0)
            {
                Debug.LogWarning("Throwing any remaining job at player...");
                Job chosenJob = Job.AllRandomJobs.First();
                Job.AllRandomJobs.Remove(chosenJob);
                AddPendingJob(chosenJob);
                continue;
            }

            Debug.LogWarning("Out of jobs to assign...");

            break;

        }

        PendingJobs.Shuffle();

    }

    static IEnumerable<Job> SearchJobs(IEnumerable<Job> jobCollection, bool guaranteedApplicability, bool guaranteedEqualTier)
    {
        bool aboveTier = Random.Range(0, 1f) < .15f;

        var query = from job in jobCollection
                    where (!guaranteedEqualTier && job.Tier <= Hero.Tier + (aboveTier? 1 : 0)) || job.Tier == Hero.Tier
                    where (!guaranteedApplicability) || Hero.CanProduceEffects(job.EffectsRequired)
                    select job;

        Debug.Log("Searching... " + guaranteedApplicability + ", " + guaranteedEqualTier + "... Found " + query.Count());

        return query;
    }

    public static void CheckEvents()
    {
        if(currentDay == 3)
            Market.Definitions[MarketID.MarkovsCurios].Unlocked = true;
        if (currentDay == 6)
            Market.Definitions[MarketID.DragonTrader].Unlocked = true;
    }

    //Markets

    public static void SwitchMarket(MarketID market)
    {
        currentMarket = Market.Definitions[market];
        currentMarket.NewWares = false;
        LayoutManager.Main.UpdateAll();
    }

    public static void BuyIngredientFromCurrentMarket(IngredientID ingredient)
    {
        Hero.gainIngredient(ingredient, 1);
        Hero.aurum -= currentMarket.Wares[ingredient].cost;
        currentMarket.Wares[ingredient].quantity--;
        LayoutManager.Main.UpdateAll();
    }

    public static bool CanBuyIngredientFromCurrentMarket(IngredientID ingredient)
    {
        return CanBuyFromListing(currentMarket.Wares[ingredient]);
    }

    public static bool CanBuySpellFromCurrentMarket(SpellID spell)
    {
        return CanBuyFromListing(currentMarket.Scrolls[spell]);
    }

    public static bool CanBuyFromListing(Market.Listing listing)
    {
        if (!currentMarket.Open)
            return false;
        if (Hero.aurum < listing.cost)
            return false;
        if (listing.quantity <= 0)
            return false;
        return true;
    }


    public static void BuyScrollFromCurrentMarket(SpellID spell)
    {
        Hero.gainSpell(spell);
        Hero.aurum -= currentMarket.Scrolls[spell].cost;
        currentMarket.Scrolls[spell].quantity--;

        if(currentMarket.Scrolls[spell].quantity <= 0)
        {
            currentMarket.Scrolls.Remove(spell);
        }

        LayoutManager.Main.UpdateAll();
    }



    //Jobs

    public static void AcceptJob()
    {
        PendingJobs.Remove(currentJob);
        AcceptedJobs.Add(currentJob);
        currentJob.accepted = true;
        LayoutManager.Main.UpdateAll();
    }

    public static void SucceedJob(Job job)
    {
        AcceptedJobs.Remove(job);
        SucceededJobs.Add(job);
        DeselectJobIfCurrent(job);
        LayoutManager.Main.UpdateAll();
    }

    public static void FailJob(Job job)
    {
        AcceptedJobs.Remove(job);
        FailedJobs.Add(job);
        DeselectJobIfCurrent(job);
        LayoutManager.Main.UpdateAll();
    }


    public static void AddPendingJob(Job job) //Quiet
    {
        PendingJobs.Add(job);
    }

    

    static void DeselectJobIfCurrent(Job job) //Quiet
    {
        if (currentJob == job)
            currentJob = null;
        AutoSelectJobIfNull();
    }

    static void AutoSelectJobIfNull() //Quiet
    {
        if (currentJob == null)
        {
            if (AcceptedJobs.Count > 0)
                SetCurrentJob(AcceptedJobs[0]);
            else if (PendingJobs.Count > 0)
                SetCurrentJob(PendingJobs[0]);
            else
                SetCurrentJob(null);
        }
    }

    

    //Spells
    static void AutoSelectSpellIfNull()
    {
        if (currentSpell == null)
        {
            Debug.Log("Pick spell");
            if (Hero.SpellsKnown.Count > 0)
                SetCurrentSpell(Hero.SpellsKnown[0]);
        }
    }

    public static void SetCurrentSpell(SpellID spellID)
    {
        Spell spell = Spell.Definitions[spellID];
        currentSpell = spell;
        LayoutManager.Main.UpdateAll();
    }

    public static void CastCurrentSpell()
    {
        Hero.castSpell(currentJob, currentSpell);
        hasActionsRemaining = false;
        LayoutManager.Main.UpdateAll();
    }

   
    

    public void InitializeGame()
    {
        Main = this;
        

        PendingJobs = new List<Job>();
        AcceptedJobs = new List<Job>();
        RejectedJobs = new List<Job>();
        DeferredJobs = new List<Job>();
        SucceededJobs = new List<Job>();
        FailedJobs = new List<Job>();

        Patron.LoadDefinitions();
        Ingredient.LoadDefinitions();
        Spell.LoadDefinitions();
        Market.LoadDefinitions();
        Job.LoadDefinitions();
        

        Hero = new Player();
        //Hero.gainSpell(SpellID.ToadHex);
        Hero.gainSpell(SpellID.HagsRemedy);

        SwitchMarket(MarketID.HiddenMarket);
        NewDay();
        LayoutManager.Main.InitialDisplayRoutine();
    }

  

    
    

    public static void SetCurrentJob(Job job)
    {
      //  if (job == null)
           // Debug.LogWarning("JOB IS NULL");
        currentJob = job;
        LayoutManager.Main.UpdateAll();
    }






    // Use this for initialization
    void Start()
    {
        InitializeGame();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
