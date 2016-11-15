using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{


    public float m_StrartingHealth = 20;


    public float m_CurrentHealth;

    private bool Dead;





    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    private void OnEnable()
    {

        m_CurrentHealth = m_StrartingHealth;
        Dead = false;


    }

    private void TakeDamage(float amount)
    {
        m_CurrentHealth -= amount;

        if (m_CurrentHealth <= 0 && !Dead)
        {
            OnDeath();
        }
    }

    public void OnDeath()
    {


        if (Dead == true)
        {
            Destroy(gameObject);
        }
    }


}
