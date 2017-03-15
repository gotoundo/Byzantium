using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBuyIngredient : MonoBehaviour {

    public IngredientID myIngredient;
    public Image image;

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
