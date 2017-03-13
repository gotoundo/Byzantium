using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//This object holds data and handles simple switching between views. It can refer to data on Engine but it should not call any Engine methods or change data.

public class LayoutManager : MonoBehaviour {

    public static LayoutManager Main;

    public Text ResourceText;
    public Text DayText;

    public ButtonPendingJob[] PendingJobButtons;
    public ButtonAcceptedJob[] AcceptedJobButtons;
    public ButtonSpellbookSpell[] SpellbookSpellButtons;

    
    public Text SpellNameText;
    public Text SpellDescriptionText;
    public Button SpellCastButton;

   
    public Text JobTitleText;
    public Text JobDescriptionText;
    public Button AcceptJobButton;


    public ButtonLocationSelect[] LocationButtons;
    public GameObject SpellbookLocationPanel;
    public GameObject MarketsLocationPanel;
    public GameObject ArtifactsLocationPanel;

    public ButtonBuyIngredient[] MarketPurchaseIngredientButtons;
    public ButtonBuyScroll[] MarketPurchaseScrollButtons;

    GameObject[] LocationPanels;
    public GameObject CurrentLocation;
    public Text MarketTitleText;

    public ButtonSwitchMarket[] SelectMarketButtons; 


    void AcquireCollections()
    {
        LocationPanels = new GameObject[] { SpellbookLocationPanel, MarketsLocationPanel, ArtifactsLocationPanel };
    }

    public void SetLocation(GameObject location)
    {
        if (location == null)
        {
            Debug.Log("Setting to null location, using spellbook instead");
            location = SpellbookLocationPanel;
        }

        CurrentLocation = location;
 
        foreach (GameObject locationPanel in LocationPanels)
            locationPanel.SetActive(locationPanel == location);

        foreach(ButtonLocationSelect button in LocationButtons)
        {
            button.gameObject.GetComponent<Button>().interactable = button.location != location;
        }
    }
     

    Spell currentSpell
    {
        get
        {
            return Engine.currentSpell;
        }
    }

    Job currentJob
    {
        get
        {
            return Engine.currentJob;
        }
    }

    Market currentMarket
    {
        get
        {
            return Engine.currentMarket;
        }
    }

    //These are not called by update all - they are driven directly by actions
    void LoadJobDescription()
    {
        if (currentJob == null)
        {
           // Debug.LogError("JOB IS NULL");
            JobTitleText.text = "No Job Selected";
            JobDescriptionText.text = "Go to sleep and see if you get new patrons tomorrow.";
        }
        else
        {
            JobTitleText.text = currentJob.title;
            JobDescriptionText.text = currentJob.GetDescription();
        }
    }
    
    void LoadSpellDescription()
    {
        if (currentSpell == null)
        {
            SpellNameText.text = "No Spell Selected";
            SpellDescriptionText.text = "Select a spell to cast";
        }
        else
        {
            SpellNameText.text = currentSpell.name;
            SpellDescriptionText.text = currentSpell.GetDescription();
        }
    }


    //These call UpdateAll

    public void InitialDisplayRoutine()
    {
        //Select spellbook panel
        SetLocation(SpellbookLocationPanel);
        UpdateAll();
    }

    public void DailyDisplayRoutine()
    {
        UpdateAll();
    }

    public void UpdateAll()
    {
        SetLocation(CurrentLocation);
        

        UpdateResourcesAndTime();
        UpdatePatronWindow();
        UpdateSpellWindow();
        UpdateLocationWindow();
    }

    //The following methods do not call UpdateAll

    //Resources Window

    public void UpdateResourcesAndTime()
    {
        DayText.text = "Day " + Engine.currentDay;

        string output = "";
        output += "Aurum " + Engine.Hero.aurum + ", P"+Engine.Hero.prestige+", T"+Engine.Hero.Tier+"\n";
        foreach (IngredientID id in Ingredient.IDs)
        {
            Ingredient ingredient = Ingredient.Definitions[id];
            output += ingredient.name + " " + Engine.Hero.myIngredients[id] + " - ";
        }
        ResourceText.text = output;
    }

    //Spell Window

    public void UpdateSpellWindow()
    {
        LoadSpellDescription();

        if (currentSpell == null || Engine.Hero == null)
        {
            SpellCastButton.interactable = false;
            return;
        }

        bool validJobTarget = !currentSpell.requiresValidTarget || (currentJob != null && Engine.AcceptedJobs.Contains(currentJob) && currentSpell.helpsCompleteJob(currentJob) && !currentJob.isComplete());
        bool hasMaterials = Engine.Hero.hasMaterialsForSpell(currentSpell);
        bool hasActions = Engine.hasActionsRemaining;
        SpellCastButton.interactable = validJobTarget && hasMaterials && hasActions;

        Text buttonText = SpellCastButton.gameObject.GetComponentInChildren<Text>();

        if (!hasActions)
            buttonText.text = "Out of Actions";
        else if (!validJobTarget)
            buttonText.text = "No Target";
        else if (!hasMaterials)
            buttonText.text = "Missing Materials";
        else
            buttonText.text = "Cast Spell";

    }


    //Patron Window

    public void UpdatePatronWindow()
    {
        LoadJobDescription();
        UpdateWaitingRoom();
        UpdateAcceptedJobs();
        AcceptJobButton.gameObject.SetActive(currentJob != null && !currentJob.accepted);
    }
    
    public void UpdateWaitingRoom()
    {
        for(int i =0; i<PendingJobButtons.Length; i++)
        {
            ButtonPendingJob currentButton = PendingJobButtons[i];

            if(Engine.PendingJobs.Count <= i)
            {
                currentButton.gameObject.SetActive(false);
            }
            else
            {
                currentButton.gameObject.SetActive(true);
                currentButton.Setup(Engine.PendingJobs[i]);
            }

            //Bold selected job
            currentButton.ButtonText.fontStyle = currentJob == currentButton.myJob ? FontStyle.Bold : FontStyle.Normal;

        }

    }

    public void UpdateAcceptedJobs()
    {
        for (int i = 0; i < AcceptedJobButtons.Length; i++)
        {
            ButtonAcceptedJob currentButton = AcceptedJobButtons[i];

            if(currentButton.myJob !=null)
                currentButton.ButtonText.text = currentButton.myJob.title + "(" + currentButton.myJob.remainingTimeToComplete + " days)";

            if (Engine.AcceptedJobs.Count <= i)
            {
                currentButton.gameObject.SetActive(false);
            }
            else
            {
                currentButton.gameObject.SetActive(true);
                currentButton.Setup(Engine.AcceptedJobs[i]);
            }

            //Bold selected job
            currentButton.ButtonText.fontStyle = currentJob == currentButton.myJob ? FontStyle.Bold : FontStyle.Normal;
        }
    }

    //Location Window
    public void UpdateLocationWindow()
    {
        //wipe notification if I'm already at this page
        if (CurrentLocation == MarketsLocationPanel)
        {
            if (Engine.currentMarket != null)
                Engine.currentMarket.NewWares = false;
        }

        UpdateSpellbookPanel();
        UpdateMarketPanel();
        UpdateArtifactPanel();

    }

    Color lightBlue = new Color(0, 0, 50, .5f);
    Color lightGreen = new Color(0, 50, 0, .5f);

    public void UpdateSpellbookPanel()
    {
        //Display buttons
        for (int i = 0; i < SpellbookSpellButtons.Length; i++)
        {
            ButtonSpellbookSpell currentButton = SpellbookSpellButtons[i];

            if (Engine.Hero.SpellsKnown.Count <= i)
            {
                currentButton.gameObject.SetActive(false);
            }
            else
            {
                currentButton.gameObject.SetActive(true);
                currentButton.Setup(Engine.Hero.SpellsKnown[i]);
            }

        }

        //Format buttons
        foreach (ButtonSpellbookSpell spellButton in SpellbookSpellButtons)
        {
            if (spellButton.mySpell != SpellID.None)
            {
                Spell spell = Spell.Definitions[spellButton.mySpell];

                //Color green if valid, otherwise white
                bool validTarget = currentJob != null && currentJob.desiresEffects(spell.EffectsProduced);
                Button button = spellButton.GetComponent<Button>();
                button.image.color = validTarget ? lightGreen : Color.white;
                
                //bold selected spell
                spellButton.ButtonText.fontStyle = currentSpell == spell ? FontStyle.Bold : FontStyle.Normal;
            }
        }
    }

    public void UpdateMarketPanel()
    {
        bool newShitInStores = false;
        foreach(KeyValuePair<MarketID,Market> entry in Market.Definitions)
        {
            if (entry.Value.Unlocked && entry.Value.NewWares)
                newShitInStores = true;
        }

        LocationButtons[1].gameObject.GetComponentInChildren<Text>().text = "Markets" + (newShitInStores ? " (!)" : "");


        MarketTitleText.text = currentMarket.name + " (" + currentMarket.status + ")";

        //Disable and enable the appropriate market buttons
        foreach(ButtonSwitchMarket marketButton in SelectMarketButtons)
        {
            marketButton.gameObject.SetActive(Market.Definitions[marketButton.myMarket].Unlocked);
            marketButton.gameObject.GetComponent<Button>().interactable = marketButton.myMarket != currentMarket.ID;
            marketButton.gameObject.GetComponentInChildren<Text>().text = Market.Definitions[marketButton.myMarket].GetTabName();
            
        }

        //Update selection of ingredients
        foreach (ButtonBuyIngredient ingredientButton in MarketPurchaseIngredientButtons)
        {
            IngredientID ingredientID = ingredientButton.myIngredient;
            Button button = ingredientButton.GetComponent<Button>();
            bool marketHasIngredient = currentMarket.Wares.ContainsKey(ingredientID);
            ingredientButton.gameObject.SetActive(marketHasIngredient);
            if (marketHasIngredient)
            {
                Text buttonText = button.gameObject.GetComponentInChildren<Text>();
                buttonText.text = ingredientID + " - " + currentMarket.Wares[ingredientID].cost + "a   (x" + currentMarket.Wares[ingredientID].quantity + " left)";
            }
            button.interactable = Engine.CanBuyIngredientFromCurrentMarket(ingredientID);
        }

        //Update selection of scrolls
        foreach (ButtonBuyScroll scrollButton in MarketPurchaseScrollButtons)
            scrollButton.gameObject.SetActive(false);

        int currentButtonPosition = 0;
        foreach (KeyValuePair<SpellID, Listing> scrollListings in currentMarket.Scrolls) //go through each of the market's scrolls
        {
            if (MarketPurchaseScrollButtons.Length > currentButtonPosition) //there's more scrolls to show
            {
                MarketPurchaseScrollButtons[currentButtonPosition].gameObject.SetActive(true);
                ButtonBuyScroll scrollButton = MarketPurchaseScrollButtons[currentButtonPosition];
                scrollButton.mySpell = scrollListings.Key;
                Button button = scrollButton.GetComponent<Button>();
                button.interactable = Engine.CanBuySpellFromCurrentMarket(scrollListings.Key);

                //Button Text
                Text buttonText = button.gameObject.GetComponentInChildren<Text>();
                List<string> effectNames = new List<string>();
                foreach (SpellEffect effect in Spell.Definitions[scrollListings.Key].EffectsProduced)
                    effectNames.Add("" + effect);
                buttonText.text = Spell.Definitions[scrollListings.Key].name + " ["+ Util.OxfordList(effectNames, true, false) + "] - " 
                    + currentMarket.Scrolls[scrollListings.Key].cost 
                    + "a"
                    + (currentMarket.Scrolls[scrollListings.Key].quantity > 1 ? "( x" + currentMarket.Scrolls[scrollListings.Key].quantity + " left)" : "");


                currentButtonPosition++;
            }
            
        }

    }



    public void UpdateArtifactPanel()
    {

    }

   



    void Awake()
    {
        Main = this;
        AcquireCollections();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
