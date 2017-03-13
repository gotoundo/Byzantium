using UnityEngine;
using System.Collections.Generic;
using System.Linq;


public enum DomainID { Waeor, Penumok, Immolian, Tempus, Anestra}

public enum SpellID { None,
    //Tier 1 Complex
    HagsRemedy,SeaferersCharm,PotionOfAphrodite,MausoleumRitual,
    //Tier 1 Simple
    LionheartPotion,BlessingOfWorms,SleepersSun,ChainOfLoyalty,VisionsOfInferno,CharlatansWig,SlitheringSensation,SeverDeformity,HeedTheBirds,RevealWorth,ConfoundMirror,
    
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
    //Tier 1
    IrritationHex,CureWarts,SanctifyCorpse,InspireBravery,InspireLove,
    AbjureNightmares,KnowWeather,InspireNightmares,GrowHair,KnowValue,
    //Tier 2
    EmbarassmentHex,MakeFearsome,AlterMemory,KnowEnchantment,DeafnessHex,
    SanctifyWedding,KnowAdmirer,CureImpotence,BanishGhost,InspireHatred,
    //Tier 3
    CureLeprosy,CureMuteness,SanctifyBirth,SanctifyPerformance,InspireDespondency,
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

        //Tier 1 Spells - Cost 6

        new Spell("Hag's Remedy", SpellID.HagsRemedy, 1, DomainID.Waeor)
            .setEffects(SpellEffect.GrowHair, SpellEffect.CureWarts)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Parchment, 3);

        new Spell("Seafarer's Charm", SpellID.SeaferersCharm, 1, DomainID.Tempus)
            .setEffects(SpellEffect.KnowWeather, SpellEffect.KnowValue)
            .addIngredient(IngredientID.Parchment, 1)
            .addIngredient(IngredientID.Salt, 1);

        new Spell("Potion of Aphrodite", SpellID.PotionOfAphrodite, 1, DomainID.Immolian)
            .setEffects(SpellEffect.InspireLove, SpellEffect.InspireBravery)
            .addIngredient(IngredientID.Ink, 1)
            .addIngredient(IngredientID.Candle, 1);

        new Spell("Mausoleum Ritual", SpellID.MausoleumRitual, 1, DomainID.Penumok)
            .setEffects(SpellEffect.SanctifyCorpse, SpellEffect.InspireNightmares)
            .addIngredient(IngredientID.Parchment, 2)
            .addIngredient(IngredientID.Ink, 2);

        new Spell("Confound Mirrors", SpellID.ConfoundMirror, 1, DomainID.Anestra)
            .setEffects(SpellEffect.AbjureNightmares, SpellEffect.IrritationHex)
            .addIngredient(IngredientID.Quartz, 1);

        //IrritationHex, CureWarts, SanctifyCorpse, CreateLuck, InspireLove, AbjureNightmares, KnowWeather, InspireNightmares, GrowHair, KnowValue,
        new Spell("Lionheart Potion", SpellID.LionheartPotion, 1, DomainID.Waeor)
            .setEffects(SpellEffect.InspireBravery)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1)
            .addIngredient(IngredientID.Parchment, 1);

        new Spell("Blessing of Worms", SpellID.BlessingOfWorms, 1, DomainID.Waeor)
            .setEffects(SpellEffect.SanctifyCorpse)
            .addIngredient(IngredientID.Fang, 2);
            
        new Spell("Sleeper's Sun", SpellID.SleepersSun, 1, DomainID.Tempus)
            .setEffects(SpellEffect.AbjureNightmares)
            .addIngredient(IngredientID.Salt, 1)
            .addIngredient(IngredientID.Parchment, 1);//Cheap!

        new Spell("Chains of Loyalty", SpellID.ChainOfLoyalty, 1, DomainID.Tempus)
            .setEffects(SpellEffect.AbjureNightmares)
            .addIngredient(IngredientID.Salt, 1)
            .addIngredient(IngredientID.Parchment, 1);

        new Spell("Vision of Inferno", SpellID.VisionsOfInferno, 1, DomainID.Immolian)
           .setEffects(SpellEffect.InspireNightmares)
           .addIngredient(IngredientID.Candle, 1)
           .addIngredient(IngredientID.Parchment, 2);

        new Spell("Charlatan's Wig", SpellID.CharlatansWig, 1, DomainID.Immolian)
           .setEffects(SpellEffect.GrowHair)
           .addIngredient(IngredientID.Candle, 1)
           .addIngredient(IngredientID.Parchment, 2);

        new Spell("Slithering Sensation", SpellID.SlitheringSensation, 1, DomainID.Penumok)
           .setEffects(SpellEffect.IrritationHex)
           .addIngredient(IngredientID.Ink, 3);

        new Spell("Gouge Deformity", SpellID.SeverDeformity, 1, DomainID.Penumok)
           .setEffects(SpellEffect.CureWarts)
           .addIngredient(IngredientID.Parchment, 1)
           .addIngredient(IngredientID.Ink, 1)
           .addIngredient(IngredientID.Fang, 1);

        new Spell("Speak with Birds", SpellID.HeedTheBirds, 1, DomainID.Anestra)
           .setEffects(SpellEffect.KnowWeather)
           .addIngredient(IngredientID.Quartz, 1);

        new Spell("Reveal Worth", SpellID.RevealWorth, 1, DomainID.Anestra)
           .setEffects(SpellEffect.KnowValue)
           .addIngredient(IngredientID.Parchment, 4)
           .addIngredient(IngredientID.Ink, 1);




        //Tier 2 Spells - Cost 9

        new Spell("Mating Ritual", SpellID.MatingRitual, 2, DomainID.Waeor)
           .setEffects(SpellEffect.CureImpotence,SpellEffect.KnowAdmirer)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);

        new Spell("Final Words", SpellID.ImmutableWords, 2, DomainID.Tempus)
           .setEffects(SpellEffect.SanctifyWedding, SpellEffect.DeafnessHex)
           .addIngredient(IngredientID.Parchment, 7)
           .addIngredient(IngredientID.Ink, 1);

        new Spell("Incense", SpellID.Incense, 2, DomainID.Immolian)
           .setEffects(SpellEffect.InspireHatred, SpellEffect.EmbarassmentHex)
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
          .setEffects(SpellEffect.EmbarassmentHex)
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
          .setEffects(SpellEffect.EmbarassmentHex)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Silence of the Grave", SpellID.SilenceOfTheGrave, 2, DomainID.Penumok)
          .setEffects(SpellEffect.DeafnessHex)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Read Runes", SpellID.ReadRunes, 2, DomainID.Penumok)
          .setEffects(SpellEffect.KnowEnchantment)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Watch the Watcher", SpellID.WatchTheWatcher, 2, DomainID.Anestra)
          .setEffects(SpellEffect.KnowAdmirer)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);

        new Spell("Winter Ceremony", SpellID.WinterCeremony, 2, DomainID.Anestra)
          .setEffects(SpellEffect.SanctifyWedding)
          .addIngredient(IngredientID.Parchment, 7)
          .addIngredient(IngredientID.Ink, 1);


        //Tier 3 Spells - Cost 14
        new Spell("Sacrificial Calf", SpellID.SacrificialCalf, 3, DomainID.Waeor)
           .setEffects(SpellEffect.SanctifyBirth, SpellEffect.HexGout)
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
           .setEffects(SpellEffect.UnderstandLanguage, SpellEffect.CureMuteness)
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
           .setEffects(SpellEffect.SanctifyBirth)
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
           .setEffects(SpellEffect.CureMuteness)
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


        /*

        //Doubles
        new Spell("Chattering Hex", SpellID.ChatteringHex, 2)
            .setEffects(SpellEffect.EmbarassmentHex, SpellEffect.CompelTruthtelling)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Fey Dust", SpellID.FeyDust, 2)
            .setEffects(SpellEffect.AlterMemory, SpellEffect.KnowEnchantment)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Satyr's Cord", SpellID.SatyrsCord, 2)
            .setEffects(SpellEffect.DeafnessHex, SpellEffect.SanctifyWedding)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Reflection of Venus", SpellID.ReflectionOfVenus, 2)
            .setEffects(SpellEffect.KnowAdmirer, SpellEffect.CureImpotence)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Hideous Masquerade", SpellID.HideousMasquerade, 2)
            .setEffects(SpellEffect.BanishGhost, SpellEffect.IllusionOfUgliness)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        //Singles
        //EmbarassmentHex, CompelTruthtelling, AlterMemory, KnowEnchantment, DeafnessHex, SanctifyWedding, KnowAdmirer, CureImpotence, BanishGhost, IllusionOfUgliness
        new Spell("Embarassment Hex", SpellID.EmbarassmentHex, 2)
            .setEffects(SpellEffect.EmbarassmentHex)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Compel Truthtelling", SpellID.CompelTruthtelling, 2)
            .setEffects(SpellEffect.CompelTruthtelling)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Alter Memory", SpellID.AlterMemory, 2)
            .setEffects(SpellEffect.AlterMemory)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Know Enchantment", SpellID.KnowEnchantment, 2)
            .setEffects(SpellEffect.KnowEnchantment)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Deafness Hex", SpellID.DeafnessHex, 2)
            .setEffects(SpellEffect.DeafnessHex)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Sanctify Wedding", SpellID.SanctifyWedding, 2)
            .setEffects(SpellEffect.SanctifyWedding)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Know Admirer", SpellID.KnowAdmirer, 2)
            .setEffects(SpellEffect.KnowAdmirer)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Cure Impotence", SpellID.CureImpotence, 2)
            .setEffects(SpellEffect.CureImpotence)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Banish Ghost", SpellID.BanishGhost, 2)
            .setEffects(SpellEffect.BanishGhost)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);

        new Spell("Illusion Of Ugliness", SpellID.IllusionOfUgliness, 2)
            .setEffects(SpellEffect.IllusionOfUgliness)
            .addIngredient(IngredientID.Fang, 1)
            .addIngredient(IngredientID.Ink, 1);
            */

        //Tier 3 Spells

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
        Definitions.Add(id, this);
    }

    public DomainID domain;
    public string name;
    public string description;
    public SpellID id;
    public int castTime;
    public int scrollCost;
    public int skill;
    public Dictionary<IngredientID, int> IngredientCost;
    public List<ArtifactID> ArtifactsRequired;
    public List<SpellEffect> EffectsProduced;

    public string GetDescription()
    {
        string output = description + "\n";

        output += "\n Skill " + skill + " Spell \n";

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

    public Spell setArtifacts(params ArtifactID[] artifacts)
    {
        ArtifactsRequired = new List<ArtifactID>(artifacts);
        return this;
    }
}