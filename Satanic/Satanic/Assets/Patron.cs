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
        new Patron("Cassandra", 1, HouseID.Hephetar);
        new Patron("Cassandra", 1, HouseID.Hephetar);
        new Patron("Cassandra", 1, HouseID.Hephetar);
        new Patron("Cassandra", 1, HouseID.Hephetar);

        new Patron("Rynald", 1, HouseID.Callius);
        new Patron("Rynald", 1, HouseID.Callius);
        new Patron("Rynald", 1, HouseID.Callius);
        new Patron("Rynald", 1, HouseID.Callius);

        new Patron("Elenor", 1, HouseID.Imperion);
        new Patron("Elenor", 1, HouseID.Imperion);
        new Patron("Elenor", 1, HouseID.Imperion);
        new Patron("Elenor", 1, HouseID.Imperion);

        new Patron("Desmond", 1, HouseID.Populus);
        new Patron("Desmond", 1, HouseID.Populus);
        new Patron("Desmond", 1, HouseID.Populus);
        new Patron("Desmond", 1, HouseID.Populus);
    }

    public Patron(string name, int rank, HouseID house) : base(name, rank, house)
    {
        AllPatrons.Add(this);
        NobleHouse.Definitions[house].members.Add(this);
    }
}

