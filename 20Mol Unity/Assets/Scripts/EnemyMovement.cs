using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public Transform Target;
    private GameObject Enemy;
    private GameObject Player;
    private float Range;
    public float Speed = 0.5f;
    private bool playerisinRange;

    [HideInInspector]
    public bool facingRight = true;
    [HideInInspector]

    // Use this for initialization
    void Start() {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
        Player = GameObject.FindGameObjectWithTag("Player");
        

    }

    // Update is called once per frame
    void Update() {
        Range = Vector2.Distance(Enemy.transform.position, Player.transform.position);
        if (playerisinRange)
        {
            Range = Vector2.Distance(Enemy.transform.position, Player.transform.position);
            //transform.LookAt(Target);
            Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, Player.transform.position, Speed * Time.deltaTime) ;
        }
        float h = Input.GetAxis("Horizontal");

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject == Player)
        {
            Debug.Log("follow the player");
            Range = Vector2.Distance(Enemy.transform.position, Player.transform.position);
            if (Range >= 15f)
            {
                transform.Translate(Vector2.MoveTowards(Enemy.transform.position, Target.position, 100) * Speed * Time.deltaTime);
            }
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
