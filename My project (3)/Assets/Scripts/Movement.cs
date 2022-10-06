using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private PlayerTurn playerTurn;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody rigid;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private bool onGround;

    // Start is called before the first frame update
    void Start()
    {
        onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTurn.IsPlayerTurn())
        {

        
        float ForwardInput = Input.GetAxis("Vertical");
        float TurnInput = Input.GetAxis("Horizontal");

        rigid.MovePosition(rigid.position + speed * transform.forward * ForwardInput * Time.deltaTime);

        rigid.MoveRotation(rigid.rotation * Quaternion.Euler(0, TurnInput * Time.deltaTime * turnSpeed, 0));


        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            Jump();
        }

        }

    }
    void Jump()
    {
        rigid.AddForce((transform.up + transform.forward) * jumpSpeed);

        onGround = false;
    }

    void OnCollisionEnter(Collision Ground)
    {
        if (Ground.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
}
