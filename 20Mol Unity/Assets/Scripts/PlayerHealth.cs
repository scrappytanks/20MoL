using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    public GameObject player;
    public float m_StrartingHealth = 20;


    public float m_CurrentHealth;







   

    // Update is called once per frame
    private void OnEnable()
    {

        m_CurrentHealth = m_StrartingHealth;
       


    }



    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "Fall")
        {
            Destroy(gameObject, 2f);
        }

        if (coll.gameObject.tag == "Spike")
        {
            Destroy(gameObject, 2f);
        }


    }

 

}
    
