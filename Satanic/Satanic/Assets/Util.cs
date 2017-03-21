using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


public static class Util
{

    public static T RandomElement<T>(IEnumerable<T> collection)
    {
        if (collection.Count() == 0)
            Debug.Log("collection too small!");
        return collection.ElementAt(UnityEngine.Random.Range(0, collection.Count()));
    }

    public static T SelectRandom<T>(params T[] collection)
    {
        return RandomElement(collection);
    }

    public static bool CollectionOverlap<T>(IEnumerable<T> first, IEnumerable<T> second)
    {
        foreach(T item in first)
        {
            if (second.Contains(item))
                return true;
        }
        return false;
    }

    public static void Shuffle<T>(this IList<T> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = UnityEngine.Random.Range(0, n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public static List<U> ValueList<T,U>(this Dictionary<T,U> dictionary)
    {
        return new List<U>(dictionary.Values);
    }

    public static List<T> KeyList<T, U>(this Dictionary<T, U> dictionary)
    {
        return new List<T>(dictionary.Keys);
    }

    public static string Proper(string input)
    {
        if (input.Length == 0)
            return "";
        return input.Substring(0, 1).ToString().ToUpper() + input.Substring(1);
    }

    public static string FirstCharToLower(string input)
    {
        return input.First().ToString().ToLower() + input.Substring(1);
    }

    public static string DescribeTime(int totalDays)
    {
        int days = totalDays % 7;
        int weeks = (totalDays / 7) % 28;
        int months = totalDays / 28;

        List<string> strings = new List<string>();

        if (months > 0)
            strings.Add(months + " " + (months > 1 ? "months" : "month"));
        if (weeks > 0)
            strings.Add(weeks + " " + (weeks > 1 ? "weeks" : "week"));
        if (days > 0 || totalDays == 0)
            strings.Add(days + " " + (days > 1 || days == 0 ? "days" : "day"));

        return OxfordList(strings, false, true);
    }

    public static string DayName(int day)
    {
        if (day == 0)
            return "Sunday";
        else if (day == 1)
            return "Monday";
        else if (day == 2)
            return "Tuesday";
        else if (day == 3)
            return "Wednesday";
        else if (day == 4)
            return "Thursday";
        else if (day == 5)
            return "Friday";
        else if (day == 6)
            return "Saturday";
        else return "DAYERROR";
    }

   /* public static string TraitName(Trait trait)
    {
        return Enum.GetName(typeof(Trait), trait);
    }

    public static string RelationString(Relation trait)
    {
        return Enum.GetName(typeof(Relation), trait);
    }*/

    public static string OxfordList(IEnumerable<IDescribeable> listables, bool twoElementComma = false, bool useAnd = true)
    {
        listables = listables.Where(d => d != null);

        List<string> stringList = new List<string>();
        foreach (IDescribeable element in listables)
            stringList.Add(element.Description());
        return OxfordList(stringList, twoElementComma, useAnd);
    }

    public static string OxfordList(IEnumerable<string> listables, bool twoElementComma = false, bool useAnd = true)
    {
        listables = listables.Where(d => d != null);
        string phrase = "";

        for (int i = 0; i < listables.Count(); i++)
        {
            phrase += listables.ElementAt(i);

            if (i != listables.Count() - 1) //if not the last element
            {
                if (listables.Count() > 2 || (listables.Count() == 2 && twoElementComma)) //and there than 2 elements, add a comma
                    phrase += ",";
                phrase += " "; //then add a space
            }

            if (listables.Count() >= 2 && i == listables.Count() - 2 && useAnd) //if penultimate element, and there are 2 or more total elements, insert an "and"
                phrase += "and ";
        }
        return phrase;
    }
}


public interface IDescribeable
{
    string Description();


}

