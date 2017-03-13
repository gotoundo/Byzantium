using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public enum IngredientID { Parchment, Ink, Fang, Candle, Salt, Quartz }

public class Ingredient
{
    public static readonly IngredientID[] IDs = {
        IngredientID.Parchment,
        IngredientID.Ink,
        IngredientID.Fang,
        IngredientID.Candle,
        IngredientID.Salt,
        IngredientID.Quartz };

    public static Dictionary<IngredientID, Ingredient> Definitions;

    public Ingredient(string name, IngredientID id, int minCost, int usualCost, int maxCost)
    {
        this.name = name;
        this.id = id;
        this.usualCost = usualCost;

        this.minCost = minCost;
        this.maxCost = maxCost;

        Definitions.Add(id, this);
    }

    public string name;
    public IngredientID id;
    public int usualCost;
    public int minCost;
    public int maxCost;


    public static void LoadDefinitions()
    {
        Definitions = new Dictionary<IngredientID, Ingredient>();

        Ingredient a = new Ingredient("Parchment", IngredientID.Parchment, 1, 1, 2);
        Ingredient b = new Ingredient("Ink", IngredientID.Ink, 1, 2, 4);
        Ingredient c = new Ingredient("Fang", IngredientID.Fang, 2, 3, 5);
        Ingredient d = new Ingredient("Candle", IngredientID.Candle, 3, 4, 6);
        Ingredient e = new Ingredient("Salt", IngredientID.Salt, 4, 5, 7);
        Ingredient f = new Ingredient("Quartz", IngredientID.Quartz, 5, 6, 8);

    }
}