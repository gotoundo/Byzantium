using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCastSpell : MonoBehaviour {

    public void Click()
    {
        Engine.CastCurrentSpell();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
