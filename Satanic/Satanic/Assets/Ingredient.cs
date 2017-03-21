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

    public Ingredient(string name, IngredientID id, int minCost, int usualCost, int maxCost, Sprite sprite)
    {
        this.name = name;
        this.id = id;
        this.usualCost = usualCost;

        this.minCost = minCost;
        this.maxCost = maxCost;

        this.sprite = sprite;

        Definitions.Add(id, this);
    }

    public string name;
    public IngredientID id;
    public int usualCost;
    public int minCost;
    public int maxCost;
    public Sprite sprite;


    public static void LoadDefinitions()
    {
        Definitions = new Dictionary<IngredientID, Ingredient>();

        Ingredient a = new Ingredient("Parchment", IngredientID.Parchment, 1, 1, 2, LayoutManager.Main.ResourceSprites[1]);
        Ingredient b = new Ingredient("Ink", IngredientID.Ink, 1, 2, 3, LayoutManager.Main.ResourceSprites[2]);
        Ingredient c = new Ingredient("Herb", IngredientID.Fang, 2, 3, 4, LayoutManager.Main.ResourceSprites[3]);
        Ingredient d = new Ingredient("Leech", IngredientID.Candle, 3, 4, 5, LayoutManager.Main.ResourceSprites[4]);
        Ingredient e = new Ingredient("Ankh", IngredientID.Salt, 4, 5, 6, LayoutManager.Main.ResourceSprites[5]);
        Ingredient f = new Ingredient("Quartz", IngredientID.Quartz, 5, 6, 7, LayoutManager.Main.ResourceSprites[6]);

    }
}