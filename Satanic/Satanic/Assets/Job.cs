using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Job
{

    public static List<Job> AllRandomJobs;

    public static void LoadDefinitions()
    {
        AllRandomJobs = new List<Job>();
        Citizen currentPatron;
        int currentRewardMin; //8	12	18	27	41	62	93
        int currentRewardMax;
        int currentTier;
        //Tier 1 Jobs
        currentTier = 1;
        currentRewardMin = 7;
        currentRewardMax = 10;

        currentPatron = new Citizen("Darius", currentTier, HouseID.Delta);
        new Job(currentPatron, currentTier,
           "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });
        new Job(currentPatron, currentTier,
           "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });
        new Job(currentPatron, currentTier,
           "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        new Job(currentPatron, currentTier,
            "Irritating Cousin", "I need you to hex my scheming cousin, nothing permanent.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        new Job(currentPatron, currentTier,
           "Irritating Brother", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        new Job(currentPatron, currentTier,
           "Irritating Sister", "I need you to hex my scheming cousin, nothing permanent.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });

        currentPatron = new Citizen("Nestor", currentTier, HouseID.Delta);
        new Job(currentPatron, currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });
        new Job(currentPatron, currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });
        new Job(currentPatron, currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        new Job(currentPatron, currentTier,
            "Unsightly Bumbs", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        new Job(currentPatron, currentTier,
            "Stricken by Acne", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        new Job(currentPatron, currentTier,
            "Ugly Warts", "Please cure my warts, no one will love me like this.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });

        currentPatron = new Citizen("Melony", currentTier, HouseID.Delta);
        new Job(currentPatron, currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });
        new Job(currentPatron, currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });
        new Job(currentPatron, currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        new Job(currentPatron, currentTier,
            "Unsettled Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        new Job(currentPatron, currentTier,
            "Bad Burial", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        new Job(currentPatron, currentTier,
            "Restless Tomb", "Please bless my dear departed brother, I'm afraid a necromancer wishes to raise his bones.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });

        currentPatron = new Citizen("Bellinda", currentTier, HouseID.Delta);
        //Protect Dreams
        new Job(currentPatron, currentTier,
           "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });
        new Job(currentPatron, currentTier,
           "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });
        new Job(currentPatron, currentTier,
           "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        new Job(currentPatron, currentTier,
            "Dark Dreams", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        new Job(currentPatron, currentTier,
            "Fitful Nights", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        new Job(currentPatron, currentTier,
            "Endless Nightmares", "I can't sleep, I'm beset by terrible nightmares. Can you cure them?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });

        currentPatron = new Citizen("Margarite", currentTier, HouseID.Delta);
        //Inspire Affection
        new Job(currentPatron, currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });
        new Job(currentPatron, currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });
        new Job(currentPatron, currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        new Job(currentPatron, currentTier,
            "Unrequited Love", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        new Job(currentPatron, currentTier,
            "Parched Lover", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        new Job(currentPatron, currentTier,
            "Loving Fixation", "My husband is growing old, and his embrace is well-intentioned but unsatisfactory. Can you make him feel passion again?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });

        currentPatron = new Citizen("Alfonse", currentTier, HouseID.Delta);
        //Instill Bravery
        new Job(currentPatron, currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });
        new Job(currentPatron, currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });
        new Job(currentPatron, currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        new Job(currentPatron, currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        new Job(currentPatron, currentTier,
            "Unlucky Sod", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        new Job(currentPatron, currentTier,
            "Lucky Day", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InstillBravery });

        currentPatron = new Citizen("Horatio", currentTier, HouseID.Delta);
        //Predict Weather
        new Job(currentPatron, currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });
        new Job(currentPatron, currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });
        new Job(currentPatron, currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        new Job(currentPatron, currentTier,
            "Stormy Port", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        new Job(currentPatron, currentTier,
            "Weather Forecast", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        new Job(currentPatron, currentTier,
            "Scan the Skies", "Is the rain going to mess up my shipments?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });

        currentPatron = new Citizen("Vallerie", currentTier, HouseID.Delta);
        //Send Nightmares
        new Job(currentPatron, currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });
        new Job(currentPatron, currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });
        new Job(currentPatron, currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        new Job(currentPatron, currentTier,
            "Treacherous Sister", "My sister is making a move on my husband. Can you send her a subtle warning?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        new Job(currentPatron, currentTier,
           "Dream Attack", "My sister is making a move on my husband. Can you send her a subtle warning?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        new Job(currentPatron, currentTier,
           "Nighttime Revenge", "My sister is making a move on my husband. Can you send her a subtle warning?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });

        currentPatron = new Citizen("Peter", currentTier, HouseID.Delta);
        //Grow Hair
        new Job(currentPatron, currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });
        new Job(currentPatron, currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });
        new Job(currentPatron, currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        new Job(currentPatron, currentTier,
            "Unhappy Dome", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        new Job(currentPatron, currentTier,
            "Bald and Bereaved", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        new Job(currentPatron, currentTier,
            "Hair Today", "Can you give me back my hair? I used to have such gorgeous locks, and women couldn't get enough...",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });

        currentPatron = new Citizen("Hellen", currentTier, HouseID.Delta);
        //Discern Value
        new Job(currentPatron, currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });
        new Job(currentPatron, currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });
        new Job(currentPatron, currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        new Job(currentPatron, currentTier,
            "Motherload", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        new Job(currentPatron, currentTier,
            "Coin Check", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        new Job(currentPatron, currentTier,
            "Suspicious Gems", "I've got a dealer who wants to sell me this gold bullion. Can you tell me if it's authentic?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });

        //Tier 2 Jobs
        currentTier = 2;
        currentRewardMin = 10;
        currentRewardMax = 15;

        currentPatron = new Citizen("Janis", currentTier, HouseID.Delta);
        //EmbarassmentHex,CompelTruthtelling,AlterMemory,KnowEnchantment,DeafnessHex,SanctifyWedding,KnowAdmirer,CureImpotence,BanishGhost,IllusionOfUgliness

        new Job(currentPatron, currentTier,
            "EmbarassmentHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Embarass });

        new Job(currentPatron, currentTier,
            "EmbarassmentHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Embarass });

        new Job(currentPatron, currentTier,
            "EmbarassmentHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Embarass });

        new Job(currentPatron, currentTier,
            "Fearsome Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.MakeFearsome });

        new Job(currentPatron, currentTier,
            "Fearsome Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.MakeFearsome });

        new Job(currentPatron, currentTier,
            "Fearsome Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.MakeFearsome });

        new Job(currentPatron, currentTier,
            "AlterMemory Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.AlterMemory });

        new Job(currentPatron, currentTier,
            "AlterMemory Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.AlterMemory });

        new Job(currentPatron, currentTier,
            "AlterMemory Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.AlterMemory });

        new Job(currentPatron, currentTier,
            "KnowEnchantment Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowEnchantment });

        new Job(currentPatron, currentTier,
            "KnowEnchantment Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowEnchantment });

        new Job(currentPatron, currentTier,
            "KnowEnchantment Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowEnchantment });

        new Job(currentPatron, currentTier,
            "DeafnessHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Deafen });

        new Job(currentPatron, currentTier,
            "DeafnessHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Deafen });

        new Job(currentPatron, currentTier,
            "DeafnessHex Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Deafen });

        new Job(currentPatron, currentTier,
            "SanctifyWedding Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyWedding });

        new Job(currentPatron, currentTier,
            "SanctifyWedding Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyWedding });

        new Job(currentPatron, currentTier,
            "SanctifyWedding Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyWedding });

        new Job(currentPatron, currentTier,
            "KnowAdmirer Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.RevealAdmirer });

        new Job(currentPatron, currentTier,
            "KnowAdmirer Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.RevealAdmirer });

        new Job(currentPatron, currentTier,
            "KnowAdmirer Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.RevealAdmirer });

        new Job(currentPatron, currentTier,
            "CureImpotence Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureImpotence });

        new Job(currentPatron, currentTier,
            "CureImpotence Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureImpotence });

        new Job(currentPatron, currentTier,
            "CureImpotence Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureImpotence });

        new Job(currentPatron, currentTier,
            "BanishGhost Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BanishGhost });

        new Job(currentPatron, currentTier,
            "BanishGhost Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BanishGhost });

        new Job(currentPatron, currentTier,
            "BanishGhost Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BanishGhost });

        new Job(currentPatron, currentTier,
            "Hatred Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireHatred });

        new Job(currentPatron, currentTier,
            "Hatred Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireHatred });

        new Job(currentPatron, currentTier,
            "Hatred Task", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireHatred });

        //Tier 3 Jobs
        currentTier = 3;
        currentRewardMin = 19;
        currentRewardMax = 23;
        currentPatron = new Citizen("Yellen", currentTier, HouseID.Gamma);

        new Job(currentPatron, currentTier,
            "Leprosy", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureLeprosy });

        new Job(currentPatron, currentTier,
            "Leprosy", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureLeprosy });

        new Job(currentPatron, currentTier,
            "Leprosy", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureLeprosy });

        new Job(currentPatron, currentTier,
            "Cure Muteness", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GiveSpeach });

        new Job(currentPatron, currentTier,
            "Cure Muteness", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GiveSpeach });

        new Job(currentPatron, currentTier,
            "Cure Muteness", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GiveSpeach });

        new Job(currentPatron, currentTier,
            "Sanctify Birth", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BlessChild });

        new Job(currentPatron, currentTier,
            "Sanctify Birth", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BlessChild });

        new Job(currentPatron, currentTier,
            "Sanctify Birth", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.BlessChild });

        new Job(currentPatron, currentTier,
            "Sanctify Performance", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyPerformance });

        new Job(currentPatron, currentTier,
            "Sanctify Performance", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyPerformance });

        new Job(currentPatron, currentTier,
            "Sanctify Performance", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyPerformance });

        new Job(currentPatron, currentTier,
            "Inspire Despondency", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireDespondency });

        new Job(currentPatron, currentTier,
            "Inspire Despondency", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireDespondency });

        new Job(currentPatron, currentTier,
            "Inspire Despondency", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireDespondency });

        new Job(currentPatron, currentTier,
            "Inspire Obsession", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireObsession });

        new Job(currentPatron, currentTier,
            "Inspire Obsession", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireObsession });

        new Job(currentPatron, currentTier,
            "Inspire Obsession", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireObsession });

        new Job(currentPatron, currentTier,
            "Gout Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexGout });

        new Job(currentPatron, currentTier,
            "Gout Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexGout });

        new Job(currentPatron, currentTier,
            "Gout Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexGout });

        new Job(currentPatron, currentTier,
            "Blindness Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexBlindness });

        new Job(currentPatron, currentTier,
            "Blindness Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexBlindness });

        new Job(currentPatron, currentTier,
            "Blindness Hex", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.HexBlindness });

        new Job(currentPatron, currentTier,
            "Understand Language", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.UnderstandLanguage });

        new Job(currentPatron, currentTier,
            "Understand Language", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.UnderstandLanguage });

        new Job(currentPatron, currentTier,
            "Understand Language", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.UnderstandLanguage });

        new Job(currentPatron, currentTier,
            "Discover Parentage", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowParentage });

        new Job(currentPatron, currentTier,
            "Discover Parentage", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowParentage });

        new Job(currentPatron, currentTier,
            "Discover Parentage", "Can you cast this spell for me?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.KnowParentage });

    }

    public string title;
    public string description;
    public Citizen patron;
    public List<SpellEffect> EffectsRequired;
    public List<SpellEffect> EffectsProvided;
    public int Tier;
    public int Reward;
    public bool accepted = false;
    public bool rewardGranted = false;
    public int totalTimeToComplete;
    public int remainingTimeToComplete;

    public Job(Citizen patron, int Tier, string title, string description, int Reward, SpellEffect[] requiredEffects)
    {
        this.patron = patron;
        this.Tier = Tier;
        this.title = title;
        this.description = description;
        this.Reward = Reward;
        EffectsRequired = new List<SpellEffect>(requiredEffects);
        EffectsProvided = new List<SpellEffect>();
        totalTimeToComplete = 4;
        remainingTimeToComplete = totalTimeToComplete;
        AllRandomJobs.Add(this);


    }

    public string GetDescription()
    {
        string output = "";
        if(accepted)
            output += "ACCEPTED JOB \n";
        else
            output += "AVAILABLE JOB \n";

        output += patron.name + " of House " + patron.house + "\n";
        
        output += "\n" + description + "\n";

        output += "\n(Within " + remainingTimeToComplete + " days, cast ";
        foreach (SpellEffect effect in EffectsRequired)
            output += effect;
        output += ")";

        output += "\n\n Reward - " + Reward + " Aurum";


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