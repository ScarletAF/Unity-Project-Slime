using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawnPoint1;
    public GameObject player1;
    public float minHeightForDeath;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player1.transform.position.y < minHeightForDeath)
            player1.transform.position = spawnPoint1.position;


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "death")
        {
            player1.transform.position = spawnPoint1.position;

        }
    }
}