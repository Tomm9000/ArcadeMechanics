using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{

    int damage = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }
        
            

    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            GameObject theEnemy = GameObject.Find("enemy");
            Enemy EnemyScript = theEnemy.GetComponent<Enemy>();
            EnemyScript.health -= damage;
        }
    }
}
