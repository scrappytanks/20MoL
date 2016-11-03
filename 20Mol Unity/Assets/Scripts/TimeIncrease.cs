using UnityEngine;
using System.Collections;

public class TimeIncrease : MonoBehaviour {

    public CountdownTimer countdownTimer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Item")
        {
            Destroy(other.gameObject);
            countdownTimer.timeLeft += 10;
        }
    }
}
