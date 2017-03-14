using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public enum DomainID { Waeor, Penumok, Immolian, Tempus, Anestra}

public enum SpellID { None,

    //Tier 1 Essential
    Alchemy,

    //Tier 1 Complex
    HagsRemedy,SeaferersCharm,PotionOfAphrodite,MausoleumRitual, ConfoundMirror,
    //Tier 1 Simple
    LionheartPotion,BlessingOfWorms,SleepersSun,ChainOfLoyalty,VisionsOfInferno,CharlatansWig,SlitheringSensation,SeverDeformity,HeedTheBirds,RevealWorth,
    
    //Tier 2 Complex
    MatingRitual,ImmutableWords,Incense,MaskOfDread,Stardust,
    //Tier 2 Simple
    RavenousAspect,HogsWriting,RadiantReliquary,SongOfRivalry,ReviseMemories,ConfuseSpeach,SilenceOfTheGrave,ReadRunes,WatchTheWatcher,WinterCeremony,
    
    //Tier 3 Complex
    SacrificialCalf,TheGoldenCrown,Masquerade,Mummify,UnstopperTruth,
    //Tier 3 Simple
    SerpentsMolt,DruidsDance,DivineArrival,LegendaryFocus,IntuitIntention,LoosenTongue,DarknessOfDepths,CorruptBlood,ChartAncestry,RevealFutility
}
public enum SpellTag { Subtle, Violent }
public enum SpellEffect
{
    MakeAurum,
    //Tier 1
    Irritation,CureWarts,SanctifyCorpse,InstillBravery,InspireAffection,
    ProtectDreams,PredictWeather,SendNightmares,GrowHair,DiscernValue,
    //Tier 2
    Embarass,MakeFearsome,AlterMemory,KnowEnchantment,Deafen,
    SanctifyWedding,RevealAdmirer,CureImpotence,BanishGhost,InspireHatred,
    //Tier 3
    CureLeprosy,GiveSpeach,BlessChild,SanctifyPerformance,InspireDespondency,
    InspireObsession,HexGout,HexBlindness,UnderstandLanguage,KnowParentage




}

public class Spell
{
    readonly int[] scrollCosts = { 9, 20, 28, 44, 64, 96 };

    public static WeightedCollection<SpellID> RandomSpells;
    public static Dictionary<SpellID, Spell> Definitions;
    public static void LoadDefinitions()
    {
        Definitions = new Dictionary<SpellID, Spell>();

        new Spell("Produce Aurum", SpellID.Alchemy, 1, DomainID.Immolian)
            .setEffects(SpellEffect.MakeAurum)
            .setRequiresValidTarget(false)
            .setAurumProduced(1);

        //Tier 1 Spells - Cost 6

        new Spell("Hag's Remedy", SpellID.HagsRemedy, 1, DomainID.Waeor)
            .setEffects(SpellEffect.GrowHair, SpellEffect.CureWarts)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Parchment, 3);

        new Spell("Seafarer's Charm", SpellID.SeaferersCharm, 1, DomainID.Tempus)
            .setEffects(SpellEffect.PredictWeather, SpellEffect.DiscernValue)
            .addIngredient(IngredientID.Parchment, 1)
            .addIngredient(IngredientID.Salt, 1);

        new Spell("Potion of Aphrodite", SpellID.PotionOfAphrodite, 1, DomainID.Immolian)
            .setEffects(SpellEffect.InspireAffection, SpellEffect.InstillBravery)
            .addIngredient(IngredientID.Ink, 1)
            .addIngredient(IngredientID.Candle, 1);

        new Spell("Mausoleum Ritual", SpellID.MausoleumRitual, 1, DomainID.Penumok)
            .setEffects(SpellEffect.SanctifyCorpse, SpellEffect.SendNightmares)
            .addIngredient(IngredientID.Parchment, 2)
            .addIngredient(IngredientID.Ink, 2);

        new Spell("Confound Mirrors", SpellID.ConfoundMirror, 1, DomainID.Anestra)
            .setEffects(SpellEffect.ProtectDreams, SpellEffect.Irritation)
            .addIngredient(IngredientID.Quartz, 1);

        //IrritationHex, CureWarts, SanctifyCorpse, CreateLuck, InspireLove, AbjureNightmares, KnowWeather, InspireNightmares, GrowHair, KnowValue,
        new Spell("Lionheart Potion", SpellID.LionheartPotion, 1, DomainID.Waeor)
            .setEffects(SpellEffect.InstillBravery)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1)
            .addIngredient(IngredientID.Parchment, 1);

        new Spell("Blessing of Worms", SpellID.BlessingOfWorms, 1, DomainID.Waeor)
            .setEffects(SpellEffect.SanctifyCorpse)
            .addIngredient(IngredientID.Fang, 2);
            
        new Spell("Sleeper's Sun", SpellID.SleepersSun, 1, DomainID.Tempus)
            .setEffects(SpellEffect.ProtectDreams)
            .addIngredient(IngredientID.Salt, 1)
            .addIngredient(IngredientID.Parchment, 1);//Cheap!

        new Spell("Chains of Loyalty", SpellID.ChainOfLoyalty, 1, DomainID.Tempus)
            .setEffects(SpellEffect.ProtectDreams)
            .addIngredient(IngredientID.Salt, 1)
            .addIngredient(IngredientID.Parchment, 1);

        new Spell("Vision of Inferno", SpellID.VisionsOfInferno, 1, DomainID.Immolian)
           .setEffects(SpellEffect.SendNightmares)
           .addIngredient(IngredientID.Candle, 1)
           .addIngredient(IngredientID.Parchment, 2);

        new Spell("Charlatan's Wig", SpellID.CharlatansWig, 1, DomainID.Immolian)
           .setEffects(SpellEffect.GrowHair)
           .addIngredient(IngredientID.Candle, 1)
           .addIngredient(IngredientID.Parchment, 2);

        new Spell("Slithering Sensation", SpellID.SlitheringSensation, 1, DomainID.Penumok)
           .setEffects(SpellEffect.Irritation)
           .addIngredient(IngredientID.Ink, 3);

        new Spell("Gouge Deformity", SpellID.SeverDeformity, 1, DomainID.Penumok)
           .setEffects(SpellEffect.CureWarts)
           .addIngredient(IngredientID.Parchment, 1)
           .addIngredient(IngredientID.Ink, 1)
           .addIngredient(IngredientID.Fang, 1);

        new Spell("Speak with Birds", SpellID.HeedTheBirds, 1, DomainID.Anestra)
           .setEffects(SpellEffect.PredictWeather)
           .addIngredient(IngredientID.Quartz, 1);

        new Spell("Reveal Worth", SpellID.RevealWorth, 1, DomainID.Anestra)
           .setEffects(SpellEffect.DiscernValue)
           .addIngredient(IngredientID.Parchment, 4)
           .addIngredient(IngredientID.Ink, 1);




        //Tier 2 Spells - Cost 9

        new Spell("Mating Ritual", SpellID.MatingRitual, 2, DomainID.Waeor)
           .setEffects(SpellEffect.CureImpotence,SpellEffect.RevealAdmirer)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);

        new Spell("Final Words", SpellID.ImmutableWords, 2, DomainID.Tempus)
           .setEffects(SpellEffect.SanctifyWedding, SpellEffect.Deafen)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);

        new Spell("Incense", SpellID.Incense, 2, DomainID.Immolian)
           .setEffects(SpellEffect.InspireHatred, SpellEffect.Embarass)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);

        new Spell("Mask of Dread", SpellID.MaskOfDread, 2, DomainID.Penumok)
           .setEffects(SpellEffect.BanishGhost, SpellEffect.MakeFearsome)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);

        new Spell("Stardust", SpellID.Stardust, 2, DomainID.Anestra)
           .setEffects(SpellEffect.KnowEnchantment, SpellEffect.AlterMemory)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);


        new Spell("Ravenous Aspect", SpellID.RavenousAspect, 2, DomainID.Waeor)
           .setEffects(SpellEffect.MakeFearsome)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);

        new Spell("Hog's Writhing", SpellID.HogsWriting, 2, DomainID.Waeor)
          .setEffects(SpellEffect.Embarass)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Radiant Reliquary", SpellID.RadiantReliquary, 2, DomainID.Tempus)
          .setEffects(SpellEffect.BanishGhost)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Song of Rivalry", SpellID.SongOfRivalry, 2, DomainID.Tempus)
          .setEffects(SpellEffect.InspireHatred)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Rewrite Memories", SpellID.ReviseMemories, 2, DomainID.Immolian)
          .setEffects(SpellEffect.AlterMemory)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Confuse Speach", SpellID.ConfuseSpeach, 2, DomainID.Immolian)
          .setEffects(SpellEffect.Embarass)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Silence of the Grave", SpellID.SilenceOfTheGrave, 2, DomainID.Penumok)
          .setEffects(SpellEffect.Deafen)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Read Runes", SpellID.ReadRunes, 2, DomainID.Penumok)
          .setEffects(SpellEffect.KnowEnchantment)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Watch the Watcher", SpellID.WatchTheWatcher, 2, DomainID.Anestra)
          .setEffects(SpellEffect.RevealAdmirer)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Winter Ceremony", SpellID.WinterCeremony, 2, DomainID.Anestra)
          .setEffects(SpellEffect.SanctifyWedding)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);


        //Tier 3 Spells - Cost 14
        new Spell("Sacrificial Calf", SpellID.SacrificialCalf, 3, DomainID.Waeor)
           .setEffects(SpellEffect.BlessChild, SpellEffect.HexGout)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("The Golden Crown", SpellID.TheGoldenCrown, 3, DomainID.Tempus)
           .setEffects(SpellEffect.HexBlindness, SpellEffect.KnowParentage)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Masquerade", SpellID.Masquerade, 3, DomainID.Immolian)
           .setEffects(SpellEffect.InspireObsession, SpellEffect.SanctifyPerformance)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Mummify", SpellID.Mummify, 3, DomainID.Penumok)
           .setEffects(SpellEffect.CureLeprosy, SpellEffect.InspireDespondency)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Unstopper Truth", SpellID.UnstopperTruth, 3, DomainID.Anestra)
           .setEffects(SpellEffect.UnderstandLanguage, SpellEffect.GiveSpeach)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);


        new Spell("Serpent's Molt", SpellID.SerpentsMolt, 3, DomainID.Waeor)
           .setEffects(SpellEffect.CureLeprosy)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Satyr's Song", SpellID.DruidsDance, 3, DomainID.Waeor)
           .setEffects(SpellEffect.SanctifyPerformance)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Divine Arrival", SpellID.DivineArrival, 3, DomainID.Tempus)
           .setEffects(SpellEffect.BlessChild)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Legendary Focus", SpellID.LegendaryFocus, 3, DomainID.Tempus)
           .setEffects(SpellEffect.InspireObsession)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Intuit Intention", SpellID.IntuitIntention, 3, DomainID.Immolian)
           .setEffects(SpellEffect.UnderstandLanguage)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Loosen Tongue", SpellID.LoosenTongue, 3, DomainID.Immolian)
           .setEffects(SpellEffect.GiveSpeach)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Darkness of Depths", SpellID.DarknessOfDepths, 3, DomainID.Penumok)
           .setEffects(SpellEffect.HexBlindness)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Corrupt Blood", SpellID.CorruptBlood, 3, DomainID.Penumok)
           .setEffects(SpellEffect.HexGout)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Chart Ancestry", SpellID.ChartAncestry, 3, DomainID.Anestra)
           .setEffects(SpellEffect.KnowParentage)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);

        new Spell("Reveal Futility", SpellID.RevealFutility, 3, DomainID.Anestra)
           .setEffects(SpellEffect.InspireDespondency)
           .addIngredient(IngredientID.Parchment, 2)
           .addIngredient(IngredientID.Quartz, 2);



        //Tier 4 Spells

        //Tier 5 Spells


        RandomSpells = new WeightedCollection<SpellID>();
        foreach(KeyValuePair<SpellID,Spell> entry in Definitions)
        {
            RandomSpells.AddWeight(entry.Key, 10 - entry.Value.skill);
        }
    }

    public int getScrollCost()
    {
        

        return scrollCosts[skill - 1];
    }

    //

    public Spell(string name, SpellID id, int castTime, DomainID domain)
    {
        this.name = name;
        this.id = id;
        this.castTime = castTime;
        this.domain = domain;
        skill = castTime;
        scrollCost = skill * 10;
        IngredientCost = new Dictionary<IngredientID, int>();
        ArtifactsRequired = new List<ArtifactID>();
        EffectsProduced = new List<SpellEffect>();
        requiresValidTarget = true;
        sprite = Util.RandomElement(LayoutManager.Main.SpellIcons);
        Definitions.Add(id, this);

    }

    public Sprite sprite;
    public DomainID domain;
    public string name;
    public string description;
    public SpellID id;
    public int castTime;
    public int scrollCost;
    public int skill;
    public bool requiresValidTarget;
    public Dictionary<IngredientID, int> IngredientCost;
    public List<ArtifactID> ArtifactsRequired;
    public List<SpellEffect> EffectsProduced;
    public int AurumProduced = 0;

    public string GetDescription()
    {
        string output = "";//description + "\n";

        output += "Level " + skill + " " + domain+" Spell \n";

        output += "\n INGREDIENTS \n";

        foreach (KeyValuePair<IngredientID, int> entry in IngredientCost)
        {
            Ingredient ingredient = Ingredient.Definitions[entry.Key];
            output += "  - " + Mathf.Min(Engine.Hero.myIngredients[entry.Key], IngredientCost[entry.Key]) + "/" + IngredientCost[entry.Key] + " " + ingredient.name + "\n";
        }
       

        
        output += "\n EFFECTS \n";
        foreach (SpellEffect effect in EffectsProduced)
            output += "  - "+effect + "\n";

        return output;
    }

    public Spell setEffects(params SpellEffect[] effects)
    {
        EffectsProduced = new List<SpellEffect>(effects);
        return this;
    }

    public Spell addIngredient(IngredientID ingr, int quantity)
    {
        IngredientCost.Add(ingr, quantity);
        return this;
    }

    public Spell setAurumProduced(int i)
    {
        AurumProduced = i;
        return this;
    }

    public Spell setRequiresValidTarget(bool require)
    {
        requiresValidTarget = require;
        return this;
    }

    public Spell setArtifacts(params ArtifactID[] artifacts)
    {
        ArtifactsRequired = new List<ArtifactID>(artifacts);
        return this;
    }

    public bool helpsCompleteJob(Job job)
    {
        //bool helps = false;
        foreach(SpellEffect effect in job.EffectsRequired)
        {
            if (EffectsProduced.Contains(effect) && !job.EffectsProvided.Contains(effect))
                return true;
        }

        return false;

                
    }
}