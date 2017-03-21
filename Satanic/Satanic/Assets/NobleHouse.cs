using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public enum HouseID { Callius, Hephetar, Imperion, Populus, None }

public class NobleHouse
{
    public static Dictionary<HouseID, NobleHouse> Definitions;

    public static Dictionary<HouseID, HouseID> OpposedHouse;

    string name;
    HouseID id;
    public Sprite sprite;
    public List<Patron> members;
    public HouseID opposedHouse;

    public NobleHouse(HouseID id, string name, Sprite sprite, HouseID opposedHouse)
    {
        this.id = id;
        this.name = name;
        this.sprite = sprite;
        this.opposedHouse = opposedHouse;

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

        OpposedHouse = new Dictionary<HouseID, HouseID>();
        OpposedHouse.Add(HouseID.Callius, HouseID.Imperion);
        OpposedHouse.Add(HouseID.Hephetar, HouseID.Populus);
        OpposedHouse.Add(HouseID.Imperion, HouseID.Callius);
        OpposedHouse.Add(HouseID.Populus, HouseID.Hephetar);

        new NobleHouse(HouseID.Callius, "Callius", LayoutManager.Main.HouseSprites[1],HouseID.Imperion);
        new NobleHouse(HouseID.Hephetar, "Hephetar", LayoutManager.Main.HouseSprites[2],HouseID.Populus);
        new NobleHouse(HouseID.Imperion, "Imperion", LayoutManager.Main.HouseSprites[3],HouseID.Callius);
        new NobleHouse(HouseID.Populus, "Populus", LayoutManager.Main.HouseSprites[4],HouseID.Hephetar);

    }

}
