using UnityEngine;
using System.Collections;

public class CheckPointScript : MonoBehaviour {

    public Transform SpawnPoint;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Respawn")
        {
            SpawnPoint.position = new Vector3(transform.position.x, transform.position.y, SpawnPoint.position.z);
        }
    }
}
