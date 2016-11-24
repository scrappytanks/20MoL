using UnityEngine;
using System.Collections;

public class EnemyDoesDamage : MonoBehaviour {

    public float damage = 5f;

    void OnCollision2DEnter(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            this.GetComponent<PlayerHealth>().m_CurrentHealth -= 1;
        }
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
