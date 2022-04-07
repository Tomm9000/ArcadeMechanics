using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launchVelocity = 100f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ball = Instantiate(projectile, transform.position,
                                                      transform.rotation);
            ball.GetComponent<Rigidbody>().AddRelativeForce(new Vector3
                                                 (0, launchVelocity * 10, 0));
        }
    }
}