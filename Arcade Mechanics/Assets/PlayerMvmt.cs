using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMvmt : MonoBehaviour
{

    public CharacterController controller;

    public float Sped = 12f;
    public float Gravity = -9.81f;
    public float Height = 3f;

    public Transform Check;
    public float Distance = 0.4f;
    public LayerMask groundMask;

    Vector3 Velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(Check.position, Distance, groundMask);

        if(isGrounded && Velocity.y < 0)
        {
            Velocity.y = -2f;
        }

        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        Vector3 Move = transform.right * X + transform.forward * Z;

        controller.Move(Move * Sped * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            Velocity.y = Mathf.Sqrt(Height * -2f * Gravity);
        }

        Velocity.y += Gravity * Time.deltaTime;

        controller.Move(Velocity * Time.deltaTime);
    }
}
