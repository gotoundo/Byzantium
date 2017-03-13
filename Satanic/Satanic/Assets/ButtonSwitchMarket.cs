using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitchMarket : MonoBehaviour {
    public MarketID myMarket;

    public void Click()
    {
        Engine.SwitchMarket(myMarket);
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
