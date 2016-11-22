using UnityEngine;
using System.Collections;

public class DamagePlayer : MonoBehaviour {

    public float damage = 5f;

    void OnCollision2DEnter(Collision2D coll)
    {
        if (coll.gameObject.tag == "Spike")
        {
            this.GetComponent<PlayerHealth>().m_CurrentHealth -= 20;
                }
    }
	// Use this for initialization
	void Start () {
        
    }
	// Update is called once per frame
	void Update () {
	
	}
}
