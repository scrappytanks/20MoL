using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int curHealth;
    public int maxHealth = 20;

	// Use this for initialization
	void Start () {
        curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if (curHealth <= 0)
        {
            Die();
        }
	}

    void Die()
    {
        //Don't need this yet
        //Application.LoadLevel(Application.loadedLevel);
    }
}
