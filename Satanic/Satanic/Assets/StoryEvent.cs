using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StoryEvent
{
    
    public string title;
    public string description;
    public Sprite sprite;
    public Reward immediateRewards;

    public StoryEvent(string title, string description, Sprite sprite, Reward immediateRewards)
    {
        this.title = title;
        this.description = description;
        this.sprite = sprite;
        this.immediateRewards = immediateRewards;
    }

}

public class Reward //can be bad or good
{
    public int Aurum;
    public int XP;
    public List<SpellID> Spells;
    public List<ArtifactID> Artifacts;
    public Dictionary<IngredientID, int> Ingredients;
    public Dictionary<HouseID, int> Reputation;
    public List<StoryEvent> Events;
    public bool Awarded;

    public Reward()
    {
        Awarded = false;
        Spells = new List<SpellID>();
        Artifacts = new List<ArtifactID>();
        Ingredients = new Dictionary<IngredientID, int>();
        Reputation = new Dictionary<HouseID, int>();
        Events = new List<StoryEvent>();
    }

    public Reward AddAurum(int amount)
    {
        this.Aurum += amount;
        return this;
    }

    public Reward AddXP(int amount)
    {
        this.XP += amount;
        return this;
    }

    public Reward AddSpells(params SpellID[] spells)
    {
        Spells.AddRange(spells);
        return this;
    }

    public Reward AddIngredient(IngredientID ingredient, int quantity)
    {
        if (!Ingredients.ContainsKey(ingredient))
            Ingredients.Add(ingredient, 0);
        Ingredients[ingredient] += quantity;
        return this;
    }

    public Reward AddReputation(HouseID house, int amount)
    {
        if (!Reputation.ContainsKey(house))
            Reputation.Add(house, 0);
        Reputation[house] += amount;
        return this;
    }

    public string GetTextDescription()
    {
        string output = "";
        List<string> rewardStrings = new List<string>();
        if (Aurum != 0)
            rewardStrings.Add(Aurum + " Aurum");
        if (XP != 0)
            rewardStrings.Add(XP + " Prestige");
        if (Spells.Count > 0)
        {
            foreach(SpellID spell in Spells)
            {
                rewardStrings.Add("Scroll of " + Spell.Definitions[spell].name);
            }
        }
        foreach(KeyValuePair<IngredientID,int> entry in Ingredients)
        {
            rewardStrings.Add(entry.Value + " " + entry.Key);
        }
        foreach (KeyValuePair<HouseID, int> entry in Reputation)
        {
            rewardStrings.Add(entry.Value + " rep with " + entry.Key);
        }

        output += Util.OxfordList(rewardStrings, true, false);

        return output;

    }

}
