using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBuyScroll : MonoBehaviour {

    public SpellID mySpell;
    public Text buttonText;
    public Image icon;

    public void Click()
    {
        Engine.BuyScrollFromCurrentMarket(mySpell);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
