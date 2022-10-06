using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{

    [SerializeField] private PlayerTurn playerTurn;
    public Transform FirePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        bool IsPlayerTurn = playerTurn.IsPlayerTurn();
        if (IsPlayerTurn)
        {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
                TurnManager.GetInstance().TriggerChangeTurn();
                var bullet = Instantiate(bulletPrefab, FirePoint.position, FirePoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = FirePoint.forward * bulletSpeed;
        }
        }


    }

}
