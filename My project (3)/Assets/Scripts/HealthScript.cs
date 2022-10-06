using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public float startHealth;
    private float hp;

    // Start is called before the first frame update
    void Start()
    {
        hp = startHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(float damage)
    {
        hp -= damage;

        if (hp <= 0f)
        {
            Die();

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
