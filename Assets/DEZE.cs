using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEZE : MonoBehaviour
{


    public GameObject Zwaard;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Zwaard.GetComponent<Animator>().Play("1H@RHAttacks");
        }
    }

}


