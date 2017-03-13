using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBuyScroll : MonoBehaviour {

    public SpellID mySpell;

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
