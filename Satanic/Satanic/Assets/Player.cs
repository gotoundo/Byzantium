using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Wizard : Citizen
{
    public Wizard(string name, int skill, int rank, HouseID house) : base(name, rank, house)
    {
        SpellsKnown = new List<SpellID>();
        Scrolls = new List<SpellID>();
        this.skill = skill;
    }

    public List<SpellID> SpellsKnown;
    public List<SpellID> Scrolls;
    public int skill;

    public IEnumerable<SpellEffect> ProducibleEffects()
    {
        List<SpellEffect> effects = new List<SpellEffect>();
        foreach(SpellID spell in SpellsKnown)
        {
            foreach(SpellEffect effect in Spell.Definitions[spell].EffectsProduced)
            {
                if (!effects.Contains(effect))
                    effects.Add(effect);
            }
        }
        return effects;
    }

    public bool CanProduceEffects(IEnumerable<SpellEffect> effects)
    {
        IEnumerable<SpellEffect> myEffects = ProducibleEffects();
        foreach(SpellEffect effect in effects)
        {
            if (myEffects.Contains(effect))
                return true;
        }
        return false;
    }
}

public class Player : Wizard
{
    readonly int[] tierRequirements = { 10, 30, 85, 185, 410, 840, 1700 };
    public int aurum;
    public int Tier;
    public int prestige;
    public float points;
    public Dictionary<IngredientID, int> myIngredients;
   

    public Player() : base("Zorlan", 1, 1, HouseID.None)
    {
        aurum = 5;
        Tier = 1;
        myIngredients = new Dictionary<IngredientID, int>();

        gainIngredient(IngredientID.Parchment, 7);
        gainIngredient(IngredientID.Ink, 3);
        gainIngredient(IngredientID.Fang, 1);
        gainIngredient(IngredientID.Candle, 1);
        gainIngredient(IngredientID.Salt, 0);
        gainIngredient(IngredientID.Quartz, 0);
    }

    public bool canBuyIngredient(IngredientID ingredient, Market market)
    {
        if (!market.Wares.ContainsKey(ingredient))
            return false;
        Listing listing = market.Wares[ingredient];
        if (aurum < listing.cost)
            return false;
        if (listing.quantity <= 0)
            return false;
        return true;
    }

    public void tryBuyIngredient(IngredientID ingredient, Market market)
    {
        if (canBuyIngredient(ingredient, market))
        {
            market.Wares[ingredient].quantity--;
            aurum -= market.Wares[ingredient].cost;
            gainIngredient(ingredient);
        }
    }


    public void GainPrestige(int points)
    {
        prestige += points;

       
        int newTier = 1;
        for(int i = 0; i < tierRequirements.Length; i++)
        {
            if (prestige >= tierRequirements[i])
                newTier = 2 + i;
        }

        while (newTier > Tier)
            LevelUp();
    }

    public void LevelUp()
    {
        Debug.Log("Level up!");
        Tier++;
    }

    public void gainSpell(SpellID spell)
    {
        SpellsKnown.Add(spell);
    }

    public void gainIngredient(IngredientID ingr, int amount = 1)
    {
        if (!myIngredients.ContainsKey(ingr))
            myIngredients.Add(ingr, 0);
        myIngredients[ingr] += amount;
    }

    public bool hasMaterialsForSpell(Spell spell)
    {
        foreach (KeyValuePair<IngredientID, int> entry in spell.IngredientCost)
        {
            if (myIngredients[entry.Key] < spell.IngredientCost[entry.Key])
                return false;
        }
        //check ingredients and artifacts
        return true;
    }


    public bool castSpell(Job job, Spell spell)
    {
        if (!hasMaterialsForSpell(spell))
        {
            Debug.LogError("Casting Spell against permission...");
        }

        foreach (KeyValuePair<IngredientID, int> entry in spell.IngredientCost)
        {
            myIngredients[entry.Key] -= entry.Value;
        }

        //consume ingredients

        foreach (SpellEffect effect in spell.EffectsProduced)
        {
            if (job.EffectsRequired.Contains(effect))
                job.EffectsProvided.Add(effect);
        }

        tryCompleteJob(job);

        return true;
    }

    public void tryCompleteJob(Job job)
    {
        if (job.isComplete())
        {
            if (!job.rewardGranted)
            {
                aurum += job.Reward;
                GainPrestige(job.Tier);
                job.rewardGranted = true;
            }
            Engine.SucceedJob(job);
        }
    }

    void showJobSuccess(Job job)
    {

    }

    void learnScroll(SpellID spell)
    {
        if (Scrolls.Contains(spell))
        {
            Scrolls.Remove(spell);
            SpellsKnown.Add(spell);
        }
    }

}