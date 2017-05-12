using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public enum PatronID {
    Arcadius, Bascilius, Phoibe, Nikolaos, Herodita, Cassander, Myrrine, Pyrrhus, Tycha, Drakon,
    Rohesia, Lucca, Daelya, Qadim, Morgana, Kajeta, Salito, Elene, Sozzo, Constantin,
    Dominicus, Virgilius, Delphina, Cyricia, Honoria, Urbanus, Iustina, Ignatius, Gereon, Katerina,
    Hammad, Gunnolf, Saewynn, Rebecca, Khalil, Aaric, Miriam, Freya, Giuseppe, Kari
}

public class Patron : Citizen
{
   // public static List<Patron> AllPatrons;
    public static Dictionary<PatronID, Patron> Directory;

    public static void LoadDefinitions()
    {


        //AllPatrons = new List<Patron>();
        Directory = new Dictionary<PatronID, Patron>();

        new Patron(PatronID.Arcadius, "Arcadius", 1, HouseID.Hephetar, false, 48);
        new Patron(PatronID.Bascilius, "Bascilius", 1, HouseID.Hephetar, false, 14);
        new Patron(PatronID.Phoibe, "Phoibe", 1, HouseID.Hephetar, true, 28);
        new Patron(PatronID.Nikolaos, "Nikolaos", 1, HouseID.Hephetar, false, 13);
        new Patron(PatronID.Herodita, "Herodita", 1, HouseID.Hephetar, true, 40);
        new Patron(PatronID.Cassander, "Cassander", 1, HouseID.Hephetar, false, 34);
        new Patron(PatronID.Myrrine, "Myrrine", 1, HouseID.Hephetar, true, 30);
        new Patron(PatronID.Pyrrhus, "Pyrrhus", 1, HouseID.Hephetar, false, 36);
        new Patron(PatronID.Tycha, "Tycha", 1, HouseID.Hephetar, true, 9);
        new Patron(PatronID.Drakon, "Drakon", 1, HouseID.Hephetar, false, 34);

        new Patron(PatronID.Rohesia, "Rohesia", 1, HouseID.Callius, true, 3);
        new Patron(PatronID.Lucca, "Lucca", 1, HouseID.Callius, false, 28);
        new Patron(PatronID.Daelya, "Daelya", 1, HouseID.Callius, true, 43);
        new Patron(PatronID.Qadim, "Qadim", 1, HouseID.Callius, false, 16);
        new Patron(PatronID.Morgana, "Morgana", 1, HouseID.Callius, true, 33);
        new Patron(PatronID.Kajeta, "Kajeta", 1, HouseID.Callius, true, 26);
        new Patron(PatronID.Salito, "Salito", 1, HouseID.Callius, false, 37);
        new Patron(PatronID.Elene, "Elene", 1, HouseID.Callius, true, 11);
        new Patron(PatronID.Sozzo, "Sozzo", 1, HouseID.Callius, false, 62);
        new Patron(PatronID.Constantin, "Constantin", 1, HouseID.Callius, false, 21);

        new Patron(PatronID.Dominicus, "Dominicus", 1, HouseID.Imperion, false, 12);
        new Patron(PatronID.Virgilius, "Virgilius", 1, HouseID.Imperion, false, 29);
        new Patron(PatronID.Delphina, "Delphina", 1, HouseID.Imperion, true, 34);
        new Patron(PatronID.Cyricia, "Cyricia", 1, HouseID.Imperion, true, 27);
        new Patron(PatronID.Honoria, "Honoria", 1, HouseID.Imperion, true, 16);
        new Patron(PatronID.Urbanus, "Urbanus", 1, HouseID.Imperion, false, 3);
        new Patron(PatronID.Iustina, "Iustina", 1, HouseID.Imperion, true, 36);
        new Patron(PatronID.Ignatius, "Ignatius", 1, HouseID.Imperion, false, 11);
        new Patron(PatronID.Gereon, "Gereon", 1, HouseID.Imperion, false, 33);
        new Patron(PatronID.Katerina, "Katerina", 1, HouseID.Imperion, true, 20);

        new Patron(PatronID.Hammad, "Hammad", 1, HouseID.Populus, false, 55);
        new Patron(PatronID.Gunnolf, "Gunnolf", 1, HouseID.Populus, false, 9);
        new Patron(PatronID.Saewynn, "Saewynn", 1, HouseID.Populus, true, 35);
        new Patron(PatronID.Rebecca, "Rebecca", 1, HouseID.Populus, true, 15);
        new Patron(PatronID.Khalil, "Khalil", 1, HouseID.Populus, false, 10);
        new Patron(PatronID.Aaric, "Aaric", 1, HouseID.Populus, false, 19);
        new Patron(PatronID.Miriam, "Miriam", 1, HouseID.Populus, true, 4);
        new Patron(PatronID.Freya, "Freya", 1, HouseID.Populus, true, 29);
        new Patron(PatronID.Giuseppe, "Giuseppe", 1, HouseID.Populus, false, 28);
        new Patron(PatronID.Kari, "Kari", 1, HouseID.Populus, true, 7);

        
    }

    public PatronID id;
    public Patron(PatronID id, string name, int rank, HouseID house, bool female, int portrait) : base(name, rank, house)
    {
        this.id = id;
        Directory.Add(id, this);
        NobleHouse.Definitions[house].members.Add(this);
        this.female = female;
        this.sprite = female ? LayoutManager.Main.FemalePortraits[portrait] : LayoutManager.Main.MalePortraits[portrait];
    }
}

