using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLocationSelect : MonoBehaviour {
    public GameObject location;

    public void Click()
    {
        LayoutManager.Main.SetLocation(location);
        LayoutManager.Main.UpdateAll();
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
