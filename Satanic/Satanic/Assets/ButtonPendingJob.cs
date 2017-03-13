﻿using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPendingJob : MonoBehaviour {

    public Job myJob;
    public Text ButtonText; 
    public void Setup(Job job)
    {
        myJob = job;
        ButtonText.text = job.title;
    }

    public void Click()
    {
        Engine.SetCurrentJob(myJob);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
