using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Patron : Citizen
{
    public static List<Patron> AllPatrons;

    public static void LoadDefinitions()
    {
        AllPatrons = new List<Patron>();
    }

    public Patron(string name, int rank, HouseID house) : base(name, rank, house)
    {
        AllPatrons.Add(this);
    }
}

