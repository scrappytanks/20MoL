using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {

    public float timeLeft = 20.0f;
    public Text counterText;


	// Use this for initialization
	void Start () {
        counterText = GetComponent<Text>() as Text;
	}
	
	// Update is called once per frame
	void Update () {
        counterText.text = (timeLeft/60f).ToString("00") + ":" + (timeLeft % 60f).ToString("00");

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
           //GameOver();
        }


	}
   
}
