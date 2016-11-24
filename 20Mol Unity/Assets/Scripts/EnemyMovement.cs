using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public Transform Target;
    private GameObject Player;
    private float Range;
    public float Speed = 0.5f;
    private bool playerisinRange;

    
    public bool facingRight = true;
    

    // Use this for initialization
    void Start() {
        Player = GameObject.FindGameObjectWithTag("Player");
        

    }

    // Update is called once per frame
    void Update() {




        Range = Vector2.Distance(transform.position, Player.transform.position);
        if (playerisinRange)
        {
            float h = Player.transform.position.x - transform.position.x;

            if (h > 0 && !facingRight)
                Flip();
            else if (h < 0 && facingRight)
                Flip();

            //transform.LookAt(Target);
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, Speed * Time.deltaTime) ;
        }
        
    }

    void Flip()
    {
        facingRight = !facingRight;
        SpriteRenderer SR = GetComponent<SpriteRenderer>();
        SR.flipX = facingRight;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject == Player)
        {
            
            playerisinRange = true;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            playerisinRange = false;
        }
    }
}
