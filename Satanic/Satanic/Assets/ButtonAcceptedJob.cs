using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAcceptedJob : MonoBehaviour {

    public Job myJob;
    public Text ButtonText;
    public Image image;
    public void Setup(Job job)
    {
        myJob = job;
        ButtonText.text = job.title;
        image.sprite = myJob.patron.sprite;
    }

    public void Click()
    {
        Engine.SetCurrentJob(myJob);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
