using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventModal : MonoBehaviour {

    public Text titleText;
    public Text descriptionText;
    public Image speakerImage;

    public void ClickClose()
    {
        LayoutManager.Main.CloseEventPanel();
    }

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
