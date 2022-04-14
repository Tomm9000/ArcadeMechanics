using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        print(health);
        if (health < 1)
        {
            Destroy(gameObject);

        }
    }
}
