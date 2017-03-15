using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public enum HouseID { Callius, Hephetar, Imperion, Populus, None }

public class NobleHouse
{
    const int startingRep = 20;
    public static Dictionary<HouseID, NobleHouse> Definitions;

    string name;
    HouseID id;
    public int playerReputation;
    public Sprite sprite;
    public List<Patron> members;
    public HouseID opposedHouse;

    public NobleHouse(HouseID id, string name, Sprite sprite, HouseID opposedHouse)
    {
        this.id = id;
        this.name = name;
        this.sprite = sprite;
        this.opposedHouse = opposedHouse;
        playerReputation = startingRep;

        members = new List<Patron>();
        Definitions.Add(id, this);
    }

    public string Title()
    {
        return "House " + name;
    }

    public static void LoadDefinitions()
    {
        Definitions = new Dictionary<HouseID, NobleHouse>();

        new NobleHouse(HouseID.Callius, "Callius", LayoutManager.Main.HouseSprites[1],HouseID.Imperion);
        new NobleHouse(HouseID.Hephetar, "Hephetar", LayoutManager.Main.HouseSprites[2],HouseID.Populus);
        new NobleHouse(HouseID.Imperion, "Imperion", LayoutManager.Main.HouseSprites[3],HouseID.Callius);
        new NobleHouse(HouseID.Populus, "Populus", LayoutManager.Main.HouseSprites[4],HouseID.Hephetar);

    }

    public void ModifyPlayerRep(int i)
    {
        playerReputation += i;
        if(playerReputation <= 0)
        {
            Engine.LoseGame("YOU HAVE EARNED THE DISPLEASURE OF "+Title());
        }
    }

}
