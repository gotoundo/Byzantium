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
        new Job(PatronID.Salito, currentTier,
           "Lone Hunter", "I got close to a woman. It was only supposed to be... pretend. Make her see my flaws. There can't be a future to this.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });
        new Job(PatronID.Iustina, currentTier,
           "Mirthless Task", "I am an initiate in the Temple of Penumok, though I cannot seem to advance - the priestess says I am too mirthful. Do you have a spell that might make me more severe?",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Irritation });
        new Job(PatronID.Miriam, currentTier,
           "Divine Displeasure", "Some ignorant fool has profaned my temple. In a flash of rage, I called down a hex upon him – as my faithful watched. Unfortunately, I have not the Gift, nor a taste for blood. I ask you to simply harass the vandal until he repents.",
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
        new Job(PatronID.Rohesia,currentTier,
            "Toad-Touched", "",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });
        new Job(PatronID.Hammad, currentTier,
            "Unmentionable Boils", "I seem to have contracted a most unfortunate ailment, a rash of painful protrusions. I beg you for relief. And no, I can assure you I have no notion of its providence. ",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.CureWarts });
        new Job(PatronID.Dominicus, currentTier,
            "Blistering Journey", "I’ve just returned from a thousand-mile diplomatic mission, and the blisters on my feet are killing me. If you have sorcery that can relieve this agony, I’ll see that you’re well rewarded.",
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
        new Job(PatronID.Daelya, currentTier,
            "Quell the Graveyard", "",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });
        new Job(PatronID.Delphina, currentTier,
            "Father’s Temper", "My poor departed father suffers from a terrible curse, causing him to rise from his tomb and accuse his children of outlandish crimes, such as murdering him for his castle. Please give the old fool his well-deserved rest.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SanctifyCorpse });
        new Job(PatronID.Saewynn, currentTier,
            "Ward the Saint", "Our temple has been honored with the body of the Traitor of Scythia, but we cannot find a philosopher willing to provide final rites. If you know the ritual, could you be persuaded to hallow the tomb?",
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
        new Job(PatronID.Qadim, currentTier,
           "Recover Melancholia", "I used to dream of my wife every night, but now I cannot seem to recall her face. Please, save this dream for me. It is all I have left of her.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });
        new Job(PatronID.Cyricia, currentTier,
           "Recurring Terrors", "Ever since my childhood, I have dreamed of a black, roiling sea, where creatures of horrid dimensions slither and writhe and devour one another. You must free me from these visions.",
           Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.ProtectDreams });
        new Job(PatronID.Rebecca, currentTier,
           "Unrelenting Omens", "I am tormented throughout the night by visions of birds, swarming in dark multitudes and screeching cacophonous warnings - I know these are omens, but I cannot understand what they mean. Can you free me from these dreams?",
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
        new Job(PatronID.Morgana, currentTier,
            "Fatal Rejection", "A man has treated me cruely. If you have any respect for my house, you will make him love me, so I may exact proportionate revenge.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });
        new Job(PatronID.Honoria, currentTier,
            "Service with a Smile", "My servants tremble and cry in my presence, ever since I had Beatrix fed to the dogs - a bit severe perhaps, but you’d understand if you tried her soup. I just wish they would laugh at my jokes again. Make them love me!",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.InspireAffection });
        new Job(PatronID.Khalil, currentTier,
            "Uninspired Lovemaking", "My favorite slave dotes on me as always, but even he will admit my lovemaking has grown predictable and routine. If you have some witchcraft that can restore the thunderous passion of my youth, then you have my coin. ",
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
        new Job(PatronID.Kajeta, currentTier,
            "Frayed Nerves", "I can't tell you why I need your help, but the things I just saw - I feel like everything is crashing down. Make me face another day, sorcerer.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Courage });
        new Job(PatronID.Urbanus, currentTier,
            "Coward’s Desire", "I have a longing in my heart, but I am too timid to confess my love - I have tried to form the words countless times, but I always betray myself. I beg you, give me the courage to tell the Countess of Eives that I cannot live without her.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Courage });
        new Job(PatronID.Aaric, currentTier,
            "Dignity over Despair", "My family has fallen into ruin, but they don’t know it yet. I fear I may not have the strength to tell them the truth without your aid - the urge to flee rises within me. Do you have any spell that might steel me for the troubles to come?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Courage });

        new Job(currentTier,
            "Long Odds", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Courage });

        new Job(currentTier,
            "Unlucky Sod", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Courage });

        new Job(currentTier,
            "Lucky Day", "My son is gambling away his inheritance. He'll never stop, but can you give him a little boost?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.Courage });

        //currentPatron = new Citizen("Horatio", currentTier, HouseID.Imperion);
        //Predict Weather
        new Job(PatronID.Sozzo, currentTier,
            "Early Sunset", "What will the winds be like the day the Ambassador of Galt arrives? I want to know if I'll be able enjoy the celebration from the timetower.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });
        new Job(PatronID.Gereon, currentTier,
            "Hunting Season", "My grandfather, the Baron, is soon to have his grand hunt. I don’t trust the witch that promised him sunshine - already, the clouds are darkening. What’s the true forecast?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.PredictWeather });
        new Job(PatronID.Giuseppe, currentTier,
            "Delayed Shipments", "Seven ships idle in harbor under ominous clouds, while my contract with the Orange Isles grows stale by the day. How strong will this storm be? My thirst for profit is only marginally outweighed by my fear of drowning.",
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
        new Job(PatronID.Elene, currentTier,
            "The Tower Falls", "I need you to send the Chancellor an omen about what will happen if he continues to defy me. You should make it clear this is his only warning.", //He has a perverse fear of invalids. 
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });
        new Job(PatronID.Ignatius, currentTier,
            "Scion’s Revenge", "My father’s advisor spoke uncouthly to me in court. Come nightfall, you will make him suffer for it.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.SendNightmares });
        new Job(PatronID.Freya, currentTier,
            "Executioner’s Sins", "The executioner has been carousing with his brothers in the beggar’s district. His crimes there cannot go unanswered. If you have a way of setting him off his edge, I may be able to prevail in a duel.",
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
        new Job(PatronID.Lucca, currentTier,
            "Dismal Dome", "",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });
        new Job(PatronID.Virgilius, currentTier,
            "Baby Faced", "I am singularly incapable of growing a beard, which has proven rather amusing to my delightfully oafish brothers. If a potion can give me a man’s shadow, it will be a small price to pay.",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.GrowHair });
        new Job(PatronID.Gunnolf, currentTier,
            "Hair Today", "I can’t get any respect from insufferable scum I command - they’re constantly snickering about my dome. We’ll see who’s laughing when they get back from week three of sewer patrol and behold my glorious mane.",
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
        new Job(PatronID.Constantin, currentTier,
            "Haul Quality", "So you see I, ah, came into possession of these golden swords, details aren't important, he point is, is the gold real?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });
        new Job(PatronID.Katerina, currentTier,
            "Corrupt Silver", "My scrying rituals have been failing, and I think my supplier is to blame. Mage to mage, can you tell me if this silver is pure?",
            Random.Range(currentRewardMin, currentRewardMax), new SpellEffect[] { SpellEffect.DiscernValue });
        new Job(PatronID.Kari, currentTier,
            "Unexpected Inheritance", "My insane great uncle has passed, and my brother and I inherited his mountain of trash. Amid the squalor we discovered a chest filled with silver and bronze rings, marked with the scarab of the Pharaoh – can they be real?",
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
    public bool Mandatory;
    public int totalTimeToComplete;
    public int remainingTimeToComplete;
    //public Dictionary<HouseID, int> RepRewardsSuccess;
    //public Dictionary<HouseID, int> RepRewardsFailure;


    public StoryEvent successEvent;
    public StoryEvent failureEvent;

    public Job(PatronID patronid, int Tier, string title, string description, int AurumReward, SpellEffect[] requiredEffects)
    {
        //if (patron == null)
        //{
          //  NobleHouse randomHouse = Util.RandomElement(NobleHouse.Definitions.Values.ToArray());
            //patron = Util.RandomElement(randomHouse.members).id;
        //}
        this.patron = Patron.Directory[patronid];

        Mandatory = Random.Range(0, 1f) < 0.2f;

        //this.patron = patron;
        this.Tier = Tier;
        this.title = title;
        this.description = description;
        EffectsRequired = new List<SpellEffect>(requiredEffects);
        EffectsProvided = new List<SpellEffect>();
        totalTimeToComplete = 3 + Random.Range(0, 2) + Random.Range(0, 2) + Random.Range(0, 2);
        remainingTimeToComplete = totalTimeToComplete;


        //Calculating rewards
        int bigRepReward = Tier * 2;
        int smallRepReward = Tier;

        Reward successRewards = new Reward()
            .AddAurum(AurumReward)
            .AddXP(Tier);

        Reward failureRewards = new Reward()
            .AddReputation(patron.house, -bigRepReward);

        if (Random.Range(0, 1f) < 0.75f) //usually jobs hurt your rep with someone else
        {
            successRewards.AddReputation(patron.house, bigRepReward);
            int enemyHousePenalty = Random.Range(bigRepReward - 1, bigRepReward + 1);
            if(enemyHousePenalty > 0)
                successRewards.AddReputation(NobleHouse.OpposedHouse[patron.house], -enemyHousePenalty);
        }
        else
            successRewards.AddReputation(patron.house, smallRepReward);

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
        

        output += patron.name + " of House " + patron.house + "\n\n";

        if (Mandatory)
            output += "MANDATORY. ";

        output +=  description + "";

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