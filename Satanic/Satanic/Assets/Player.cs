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

    public List<SpellEffect> ProducibleEffects()
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
    public int Aurum;
    public int Level; //skill level
    public int XP;
    public Dictionary<HouseID, int> Reputation;
    public Dictionary<IngredientID, int> myIngredients;
   

    public Player() : base("Zorlan", 1, 1, HouseID.None)
    {
        Aurum = 9;
        Level = 1;
        myIngredients = new Dictionary<IngredientID, int>();
        Reputation = new Dictionary<HouseID, int>();

        GainIngredient(IngredientID.Parchment, 7);
        GainIngredient(IngredientID.Ink, 3);
        GainIngredient(IngredientID.Fang, 1);
        GainIngredient(IngredientID.Candle, 1);
        GainIngredient(IngredientID.Salt, 1);
        GainIngredient(IngredientID.Quartz, 1);

        foreach(HouseID house in NobleHouse.Definitions.KeyList())
        {
            Reputation.Add(house, Engine.startingRep);
        }

    }

    public bool canBuyIngredient(IngredientID ingredient, Market market)
    {
        if (!market.Wares.ContainsKey(ingredient))
            return false;
        Listing listing = market.Wares[ingredient];
        if (Aurum < listing.cost)
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
            Aurum -= market.Wares[ingredient].cost;
            GainIngredient(ingredient);
        }
    }


    //Gaining Rewards

    public void RecieveReward(Reward reward)
    {
        GainAurum(reward.Aurum);
        GainXP(reward.XP);
        foreach (SpellID spell in reward.Spells)
            GainSpell(spell);
        foreach (KeyValuePair<IngredientID, int> entry in reward.Ingredients)
            myIngredients[entry.Key] += entry.Value;
        foreach (KeyValuePair<HouseID, int> entry in reward.Reputation)
            GainReputation(entry.Key, entry.Value);

        foreach (StoryEvent story in reward.Events)
            Engine.AddStoryEvent(story);

        reward.Awarded = true;
    }

    public void GainReputation(HouseID house, int amount)
    {
        Reputation[house] += amount;

        if(Reputation[house] <= 0)
        {
            Engine.LoseGame("YOU HAVE EARNED THE DISPLEASURE OF " + house);
        }

        if(Reputation[house] >= 100)
        {
            Engine.WinGame("YOU HAVE BEEN EXALTED BY " + house);
        }

    }

    public void GainAurum(int amount)
    {
        Aurum += amount;
    }
    
    public void GainXP(int points)
    {
        XP += points;
       
        int newTier = 1;
        for(int i = 0; i < tierRequirements.Length; i++)
        {
            if (XP >= tierRequirements[i])
                newTier = 2 + i;
        }

        while (newTier > Level)
            LevelUp();
    }

    public void LevelUp()
    {
        Debug.Log("Level up!");
        Level++;
    }

    public void GainSpell(SpellID spell)
    {
        SpellsKnown.Add(spell);
    }

    public void GainIngredient(IngredientID ingr, int amount = 1)
    {
        if (!myIngredients.ContainsKey(ingr))
            myIngredients.Add(ingr, 0);
        myIngredients[ingr] += amount;
    }




    //Casting Spells

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

        //consume ingredients
        foreach (KeyValuePair<IngredientID, int> entry in spell.IngredientCost)
        {
            myIngredients[entry.Key] -= entry.Value;
        }

        //gain results
        RecieveReward(spell.CastRewards);

        foreach (SpellEffect effect in spell.EffectsProduced)
        {
            if (job.EffectsRequired.Contains(effect))
                job.EffectsProvided.Add(effect);
        }

        Engine.CheckJobForCompletion(job);

        return true;
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