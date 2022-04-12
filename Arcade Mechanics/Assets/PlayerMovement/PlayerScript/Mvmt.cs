using UnityEngine;

public class Mvmt : MonoBehaviour
{
    private Rigidbody rb;
    public float Zoomyspeed = 5f;
    public float ZoomyspeedSprint = 10f;
    public float jumpPower = 7;
    public bool canJump = true;
    public Camera Cam;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {

        float goHorizontal = Input.GetAxis("Horizontal");
        float goVertical = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * goHorizontal + transform.forward * goVertical;

        rb.AddForce(movement * Zoomyspeed);
        rb.drag = 2.5f;


        // jump
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rb.velocity = new Vector3(0, jumpPower, 0);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Zoomyspeed = ZoomyspeedSprint;
        }
     
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Zoomyspeed = 5f;
        }

    }
    // stuff voor jump
    private void OnCollisionEnter(Collision collision)
    {
        canJump = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        canJump = false;
    }
}