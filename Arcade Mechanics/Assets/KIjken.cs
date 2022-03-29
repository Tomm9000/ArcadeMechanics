using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KIjken : MonoBehaviour
{

    public float SensitivityMouse = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float LookX = Input.GetAxis("Mouse X") * SensitivityMouse * Time.deltaTime;
        float LookY = Input.GetAxis("Mouse Y") * SensitivityMouse * Time.deltaTime;

        xRotation -= LookY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * LookX);
    }
}
