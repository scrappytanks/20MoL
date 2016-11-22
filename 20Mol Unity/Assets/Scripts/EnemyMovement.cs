using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public Transform Target;
    private GameObject Enemy;
    private GameObject Player;
    private float Range;
    private float Speed = 0.5f;
    private bool playerisinRange;

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
            //Range = Vector2.Distance(Enemy.transform.position, Player.transform.position);
            //transform.LookAt(Target);
            Enemy.transform.position = Vector2.MoveTowards(Enemy.transform.position, Player.transform.position, Speed * Time.deltaTime) ;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject == Player)
        {
            Debug.Log("follow the player");
            //Range = Vector2.Distance(Enemy.transform.position, Player.transform.position);
            //if (Range >= 15f)
            //{
            //    transform.Translate(Vector2.MoveTowards(Enemy.transform.position, Target.position, 100) * Speed * Time.deltaTime);
            //}
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
