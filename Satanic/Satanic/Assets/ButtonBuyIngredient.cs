using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBuyIngredient : MonoBehaviour {

    public IngredientID myIngredient;

    public void Click()
    {
        Engine.BuyIngredientFromCurrentMarket(myIngredient);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
