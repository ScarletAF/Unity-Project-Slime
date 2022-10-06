using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn2 : MonoBehaviour
{
    public Transform spawnPoint2;
    public float minHeightForDeath;
    public GameObject player2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player2.transform.position.y < minHeightForDeath)
            player2.transform.position = spawnPoint2.position;
    }
}
