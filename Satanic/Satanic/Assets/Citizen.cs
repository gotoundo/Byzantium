using UnityEngine;
using System.Collections.Generic;
using System.Linq;




public class Citizen
{
    public string name;
    public HouseID house;
    public int rank;
    public static List<Citizen> AllCitizens;

    public Citizen(string name, int rank, HouseID house)
    {
        this.name = name;
        this.house = house;
        this.rank = rank;
    }
}
