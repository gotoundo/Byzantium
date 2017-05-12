using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPendingJob : MonoBehaviour {

    public Job myJob;
    public Text ButtonText;
    public Image icon;
    public void Setup(Job job)
    {
        myJob = job;
        ButtonText.text = job.title;
        icon.sprite = myJob.patron.sprite;
    }

    public void Click()
    {
        Engine.PlayerSelectsJob(myJob);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ExchangeRate(int i, int count)
    {
        i++;
        Debug.Log(i + " of " + count);
        if (i < count)
            ExchangeRate(i, count + Random.Range(-1, 2));
    }

}
