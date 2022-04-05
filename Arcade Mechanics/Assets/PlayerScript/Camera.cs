using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    // Sens
    public float mouseSensitivity = 500.0f;

    // Vind lichaam
    public Transform playerBody;

    float xRotate = 0f;

    void Start()
    {

    }

    void Update()
    {
        // Vind input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = -Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Omhoog kijken
        xRotate += mouseY;
        // Zorg ervoor dat ie niet verder dan -90 en 90 graden kan
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        // Rotate het lichaam met de camera
        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

    }
}
