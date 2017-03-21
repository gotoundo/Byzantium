using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Job
{

    public static List<Job> AllRandomJobs;

    public static void LoadDefinitions()
    {
        AllRandomJobs = new List<Job>();
        //Citizen currentPatron;
        int currentRewardMin; //8	12	18	27	41	62	93
        int currentRewardMax;
        int currentTier;
        //Tier 1 Jobs
        currentTier = 1;
        currentRewardMin = 7;
        currentRewardMax = 10;

        //currentPatron = new Citizen("Darius", currentTier, HouseID.Imperion);
        new Job(currentTier,
           "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });
        new Job(currentTier,
           "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });
        new Job(currentTier,
           "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        new Job(currentTier,
            "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        new Job(currentTier,
           "Irritating Brother", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        new Job(currentTier,
           "Irritating Sister", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        //currentPatron = new Citizen("Nestor", currentTier, HouseID.Imperion);
        new Job(currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });
        new Job(currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });
        new Job(currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        new Job(currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        new Job(currentTier,
            "Stricken by Acne", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        new Job(currentTier,
            "Ugly Warts", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        //currentPatron = new Citizen("Melony", currentTier, HouseID.Imperion);
        new Job(currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });
        new Job(currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });
        new Job(currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        new Job(currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        new Job(currentTier,
            "Bad Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        new Job(currentTier,
            "Restless Tomb", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        //currentPatron = new Citizen("Bellinda", currentTier, HouseID.Imperion);
        //Protect Dreams
        new Job(currentTier,
           "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });
        new Job(currentTier,
           "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });
        new Job(currentTier,
           "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        new Job(currentTier,
            "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        new Job(currentTier,
            "Fitful Nights", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        new Job(currentTier,
            "Endless Nightmares", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        //currentPatron = new Citizen("Margarite", currentTier, HouseID.Imperion);
        //Inspire Affection
        new Job(currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });
        new Job(currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });
        new Job(currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        new Job(currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        new Job(currentTier,
            "Parched Lover", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        new Job(currentTier,
            "Loving Fixation", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        //currentPatron = new Citizen("Alfonse", currentTier, HouseID.Imperion);
        //Instill Bravery
        new Job(currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });
        new Job(currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });
        new Job(currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        new Job(currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        new Job(currentTier,
            "Unlucky Sod", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        new Job(currentTier,
            "Lucky Day", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        //currentPatron = new Citizen("Horatio", currentTier, HouseID.Imperion);
        //Predict Weather
        new Job(currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });
        new Job(currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });
        new Job(currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        new Job(currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        new Job(currentTier,
            "Weather Forecast", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        new Job(currentTier,
            "Scan the Skies", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        //currentPatron = new Citizen("Vallerie", currentTier, HouseID.Imperion);
        //Send Nightmares
        new Job(currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });
        new Job(currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });
        new Job(currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        new Job(currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        new Job(currentTier,
           "Dream Attack", "My sister is making a move on my husband. Can you send her a subtle warning?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        new Job(currentTier,
           "Nighttime Revenge", "My sister is making a move on my husband. Can you send her a subtle warning?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        //currentPatron = new Citizen("Peter", currentTier, HouseID.Imperion);
        //Grow Hair
        new Job(currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });
        new Job(currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });
        new Job(currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        new Job(currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        new Job(currentTier,
            "Bald and Bereaved", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        new Job(currentTier,
            "Hair Today", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        //currentPatron = new Citizen("Hellen", currentTier, HouseID.Imperion);
        //Discern Value
        new Job(currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });
        new Job(currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });
        new Job(currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        new Job(currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        new Job(currentTier,
            "Coin Check", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        new Job(currentTier,
            "Suspicious Gems", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        //Tier 2 Jobs
        currentTier = 2;
        currentRewardMin = 10;
        currentRewardMax = 15;

        //currentPatron = new Citizen("Janis", currentTier, HouseID.Imperion);
        //EmbarassmentHex,CompelTruthtelling,AlterMemory,KnowEnchantment,DeafnessHex,SanctifyWedding,KnowAdmirer,CureImpotence,BanishGhost,IllusionOfUgliness

        new Job(currentTier,
            "EmbarassmentHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Embarass });

        new Job(currentTier,
            "EmbarassmentHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Embarass });

        new Job(currentTier,
            "EmbarassmentHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Embarass });

        new Job(currentTier,
            "Fearsome Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.MakeFearsome });

        new Job(currentTier,
            "Fearsome Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.MakeFearsome });

        new Job(currentTier,
            "Fearsome Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.MakeFearsome });

        new Job(currentTier,
            "AlterMemory Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.AlterMemory });

        new Job(currentTier,
            "AlterMemory Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.AlterMemory });

        new Job(currentTier,
            "AlterMemory Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.AlterMemory });

        new Job(currentTier,
            "KnowEnchantment Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowEnchantment });

        new Job(currentTier,
            "KnowEnchantment Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowEnchantment });

        new Job(currentTier,
            "KnowEnchantment Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowEnchantment });

        new Job(currentTier,
            "DeafnessHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Deafen });

        new Job(currentTier,
            "DeafnessHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Deafen });

        new Job(currentTier,
            "DeafnessHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Deafen });

        new Job(currentTier,
            "SanctifyWedding Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyWedding });

        new Job(currentTier,
            "SanctifyWedding Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyWedding });

        new Job(currentTier,
            "SanctifyWedding Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyWedding });

        new Job(currentTier,
            "KnowAdmirer Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.RevealAdmirer });

        new Job(currentTier,
            "KnowAdmirer Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.RevealAdmirer });

        new Job(currentTier,
            "KnowAdmirer Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.RevealAdmirer });

        new Job(currentTier,
            "CureImpotence Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureImpotence });

        new Job(currentTier,
            "CureImpotence Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureImpotence });

        new Job(currentTier,
            "CureImpotence Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureImpotence });

        new Job(currentTier,
            "BanishGhost Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BanishGhost });

        new Job(currentTier,
            "BanishGhost Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BanishGhost });

        new Job(currentTier,
            "BanishGhost Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BanishGhost });

        new Job(currentTier,
            "Hatred Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireHatred });

        new Job(currentTier,
            "Hatred Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireHatred });

        new Job(currentTier,
            "Hatred Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireHatred });

        //Tier 3 Jobs
        currentTier = 3;
        currentRewardMin = 19;
        currentRewardMax = 23;
        //currentPatron = new Citizen("Yellen", currentTier, HouseID.Populus);

        new Job(currentTier,
            "Leprosy", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureLeprosy });

        new Job(currentTier,
            "Leprosy", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureLeprosy });

        new Job(currentTier,
            "Leprosy", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureLeprosy });

        new Job(currentTier,
            "Cure Muteness", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GiveSpeach });

        new Job(currentTier,
            "Cure Muteness", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GiveSpeach });

        new Job(currentTier,
            "Cure Muteness", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GiveSpeach });

        new Job(currentTier,
            "Sanctify Birth", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BlessChild });

        new Job(currentTier,
            "Sanctify Birth", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BlessChild });

        new Job(currentTier,
            "Sanctify Birth", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BlessChild });

        new Job(currentTier,
            "Sanctify Performance", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyPerformance });

        new Job(currentTier,
            "Sanctify Performance", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyPerformance });

        new Job(currentTier,
            "Sanctify Performance", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyPerformance });

        new Job(currentTier,
            "Inspire Despondency", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireDespondency });

        new Job(currentTier,
            "Inspire Despondency", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireDespondency });

        new Job(currentTier,
            "Inspire Despondency", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireDespondency });

        new Job(currentTier,
            "Inspire Obsession", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireObsession });

        new Job(currentTier,
            "Inspire Obsession", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireObsession });

        new Job(currentTier,
            "Inspire Obsession", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireObsession });

        new Job(currentTier,
            "Gout Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexGout });

        new Job(currentTier,
            "Gout Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexGout });

        new Job(currentTier,
            "Gout Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexGout });

        new Job(currentTier,
            "Blindness Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexBlindness });

        new Job(currentTier,
            "Blindness Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexBlindness });

        new Job(currentTier,
            "Blindness Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexBlindness });

        new Job(currentTier,
            "Understand Language", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.UnderstandLanguage });

        new Job(currentTier,
            "Understand Language", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.UnderstandLanguage });

        new Job(currentTier,
            "Understand Language", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.UnderstandLanguage });

        new Job(currentTier,
            "Discover Parentage", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowParentage });

        new Job(currentTier,
            "Discover Parentage", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowParentage });

        new Job(currentTier,
            "Discover Parentage", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowParentage });

    }

    public string title;
    public string description;
    public Citizen patron;
    public List<SpellEffect> EffectsRequired;
    public List<SpellEffect> EffectsProvided;
    public int Tier;
    //public int Reward;
    public bool accepted = false;
    public bool rewardGranted = false;
    public int totalTimeToComplete;
    public int remainingTimeToComplete;
    //public Dictionary<HouseID, int> RepRewardsSuccess;
    //public Dictionary<HouseID, int> RepRewardsFailure;


    public StoryEvent successEvent;
    public StoryEvent failureEvent;

    public Job(int Tier, string title, string description, int AurumReward, SpellEffect[] requiredEffects)
    {
        NobleHouse randomHouse = Util.RandomElement(NobleHouse.Definitions.Values.ToArray());
        Patron randomPatron = Util.RandomElement(randomHouse.members);
        this.patron = randomPatron;

        //this.patron = patron;
        this.Tier = Tier;
        this.title = title;
        this.description = description;
        EffectsRequired = new List<SpellEffect>(requiredEffects);
        EffectsProvided = new List<SpellEffect>();
        totalTimeToComplete = 3 + Random.Range(0, 2) + Random.Range(0, 2) + Random.Range(0, 2);
        remainingTimeToComplete = totalTimeToComplete;


        //Calculating rewards
        Reward successRewards = new Reward()
            .AddAurum(AurumReward)
            .AddXP(Tier);

        Reward failureRewards = new Reward()
            .AddReputation(patron.house, -Tier);

        if (Random.Range(0, 1f) < 0.6f) //usually jobs hurt your rep with someone else
        {
            int fullReward = Tier * 2;
            successRewards.AddReputation(patron.house, fullReward);
            successRewards.AddReputation(NobleHouse.OpposedHouse[patron.house], -(fullReward - 1));
        }
        else
            successRewards.AddReputation(patron.house, Tier);

        //Creating resulting events
        successEvent = new StoryEvent(title + " Complete!", "Nicely done. Here's your payment. \n\n" + successRewards.GetTextDescription()
            ,patron.sprite,successRewards);
        failureEvent = new StoryEvent(title + " Failed", "You've failed me and disgraced yourself. \n\n" + failureRewards.GetTextDescription(), patron.sprite, failureRewards);
        

        AllRandomJobs.Add(this);

    }

    public string GetTitle()
    {
        string status = "";
        if(accepted)
            status += "";
        else
           status += "";
        return status + title;
    }

    public string GetDescription()
    {
        string output = "";
        

        output += patron.name + " of House " + patron.house + "\n";
        
        output += "\n" + description + "";

        output += " (Within " + remainingTimeToComplete + " days, cast ";
        foreach (SpellEffect effect in EffectsRequired)
            output += effect;
        output += ")";

        output += "\n\n Rewards: ";

        output += successEvent.immediateRewards.GetTextDescription();

        return output;
    }

    public bool isComplete()
    {
        foreach (SpellEffect requirement in EffectsRequired)
        {
            if (!EffectsProvided.Contains(requirement))
                return false;
        }
        return true;
    }



    public bool desiresEffects(IEnumerable<SpellEffect> proposedEffects)
    {

        List<SpellEffect> desiredEffects = new List<SpellEffect>(EffectsRequired.ToArray());
        foreach(SpellEffect providedEffect in EffectsProvided)
        {
            if (desiredEffects.Contains(providedEffect))
                desiredEffects.Remove(providedEffect);
        }

        foreach(SpellEffect effect in proposedEffects)
        {
            if (desiredEffects.Contains(effect))
                return true;
        }

        return false;
    }
}