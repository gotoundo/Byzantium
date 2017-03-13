using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public enum MarketID { HiddenMarket, MarkovsCurios, DragonTrader};

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
    public int Tier;
    public bool NewWares;

    public static void LoadDefinitions()
    {
        Definitions = new Dictionary<MarketID, Market>();
        Definitions.Add(MarketID.HiddenMarket, new Market("Hidden Market", MarketID.HiddenMarket, 1, 3, 0));
        Definitions.Add(MarketID.MarkovsCurios, new Market("Markov's Curios", MarketID.MarkovsCurios, 2, 3, 2));
        Definitions.Add(MarketID.DragonTrader, new Market("Dragon Trader", MarketID.DragonTrader, 3, 3, 5));

        Definitions[MarketID.HiddenMarket].Unlocked = true;
    }

    public Market(string name, MarketID ID, int Tier, int idealScrollCount, int restockDay)
    {
        this.name = name;
        this.ID = ID;
        Wares = new Dictionary<IngredientID, Listing>();
        Scrolls = new Dictionary<SpellID, Listing>();
        //restockDay = Random.Range(0, 7);
        this.restockDay = restockDay;
        this.idealScrollCount = idealScrollCount;
        this.Tier = Tier;

        foreach (IngredientID ingr in Ingredient.IDs)
            Wares.Add(ingr, new Listing(Ingredient.Definitions[ingr].usualCost, 6));
        Restock();
        NormalPrices();
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
                            where Spell.Definitions[spellID].skill == Tier
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
}