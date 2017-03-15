using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public enum MarketID { HiddenMarket, Scriptorium, DragonTrader};

public class Market
{
    public static Dictionary<MarketID, Market> Definitions;
    public Dictionary<IngredientID, Listing> Wares;
    public Dictionary<SpellID, Listing> Scrolls;
    public string name;
    public string status;
    public MarketID ID;

    public bool Open;
    public bool Unlocked = false;
    public int restockDay;
    public int idealScrollCount;
    public int idealArtifactsSold;
    public bool sellsIngredients;
    public int Tier;
    public bool NewWares;
    public int tierUnlocked;

    public static void LoadDefinitions()
    {
        Definitions = new Dictionary<MarketID, Market>();
        new Market("Hidden Market", MarketID.HiddenMarket, true, 1, 0, 0, 0);
        new Market("Scriptorium", MarketID.Scriptorium, false, 1, 5, 0, 2);
        new Market("Markov's Curios", MarketID.DragonTrader, true, 2, 0, 5, 5);
    }

    public Market(string name, MarketID ID, bool sellsIngredients, int tierUnlocked, int idealScrollCount, int idealArtifactsSold, int restockDay)
    {
        this.name = name;
        this.ID = ID;
        this.sellsIngredients = sellsIngredients;
        this.tierUnlocked = tierUnlocked;
        this.idealArtifactsSold = idealArtifactsSold;
        Wares = new Dictionary<IngredientID, Listing>();
        Scrolls = new Dictionary<SpellID, Listing>();
        //restockDay = Random.Range(0, 7);
        this.restockDay = restockDay;
        this.idealScrollCount = idealScrollCount;
        this.Tier = 1;

        if (sellsIngredients)
        {
            foreach (IngredientID ingr in Ingredient.IDs)
                Wares.Add(ingr, new Listing(Ingredient.Definitions[ingr].usualCost, 10));
        }
        Restock();
        NormalPrices();

        Definitions.Add(ID, this);
    }

    public string GetTabName()
    {
        return name + (NewWares ? "(!)" : "");
    }

    public void SalePrices()
    {
        foreach (KeyValuePair<IngredientID, Listing> entry in Wares)
        {
            entry.Value.cost = Random.Range(Ingredient.Definitions[entry.Key].minCost, Ingredient.Definitions[entry.Key].usualCost + 1);
        }
    }

    public void ExpensivePrices()
    {
        foreach (KeyValuePair<IngredientID, Listing> entry in Wares)
        {
            entry.Value.cost = Random.Range(Ingredient.Definitions[entry.Key].usualCost, Ingredient.Definitions[entry.Key].maxCost + 1);
        }
    }

    public void NormalPrices()
    {
        foreach (KeyValuePair<IngredientID, Listing> entry in Wares)
        {
            entry.Value.cost = Random.Range(Ingredient.Definitions[entry.Key].minCost, Ingredient.Definitions[entry.Key].maxCost + 1);
        }
    }

    public void Restock()
    {
        foreach (KeyValuePair<IngredientID, Listing> entry in Wares)
        {
            entry.Value.quantity = entry.Value.maxQuantity;
        }


        //Restock Scrolls
        Scrolls.Clear();

        var query = from spellID in Spell.RandomSpells.KeyList()
                    where Engine.Hero == null || !Engine.Hero.SpellsKnown.Contains(spellID)
                    where Spell.Definitions[spellID].skill <= (Engine.Hero == null ? 1 : Engine.Hero.Level)
                    select spellID;
        List<SpellID> validSpellIDs = new List<SpellID>(query);
        validSpellIDs.Shuffle();


        while (Scrolls.Count < idealScrollCount && validSpellIDs.Count > 0)
        {
            SpellID spellID = validSpellIDs.First();
            Scrolls.Add(spellID, new Listing(Spell.Definitions[spellID].getScrollCost(), 1));
            validSpellIDs.Remove(spellID);
        }
    }

    public void DailyUpdateStore()
    {
        if(Engine.currentDay % Engine.daysInWeek == restockDay) //the store is closed on stocking day
        {
            status = "Closed";
            Open = false;
           // NewWares = false;
            NormalPrices();
        }
        else if ((Engine.currentDay+1) % Engine.daysInWeek == restockDay) //right before stocking day, prices are cheap
        {
            NewWares = true;
            Restock();
            status = "Sale!";
            Open = true;
            SalePrices();
        }
        else if ((Engine.currentDay -1) % Engine.daysInWeek == restockDay) //right after stocking day, prices are expensive
        {
            status = "Pricy!";
            Open = true;
            ExpensivePrices();
        }
        else //otherwise, a normal fluxuation of prices
        {
            status = "Open";
            Open = true;
            NormalPrices();
        }
    }
        


    
    
}

public class Listing
{
    public Listing(int cost, int maxQuantity)
    {
        this.cost = cost;
        this.maxQuantity = maxQuantity;
        quantity = maxQuantity;
    }
    public int cost;
    public int quantity;
    public int maxQuantity;
}