using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {


    public float m_StrartingHealth = 100f;


    public float m_CurrentHealth;

    private bool m_Dead;





	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	private void OnEnable() {

        m_CurrentHealth = m_StrartingHealth;
        m_Dead = false;

	
	}

    private void TakeDamage(float amount)
    {
        m_CurrentHealth -= amount;

        if (m_CurrentHealth <= 0f && !m_Dead)
        {
            OnDeath();
        }
 }

    private void OnDeath()
    {
        m_Dead = true;

        gameObject.SetActive(false);

    }


}
