using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public float timeIncrease = 3;
    public bool timeElapsed = false;

    public int items;
    private int itemsRemaining;
    private object timeRemaining;

    // Use this for initialization
    void Start() {
        GameObject[] items = GameObject.FindGameObjectsWithTag("item") as GameObject[];
        itemsRemaining = items.Length;

        BroadcastMessage("Start Timer", timeRemaining);
    }

    // Update is called once per frame
    void Update() {
        if (itemsRemaining == 0)
        {
            //not sure i need this
        }

        if (timeElapsed)
        {
            //you lose
        }
    }
    void timeHasElapsed()
    {
        timeElapsed = true;
    }

    void increaseTime()
    {
        BroadcastMessage("timeIncrease", timeIncrease);
    }
	}
