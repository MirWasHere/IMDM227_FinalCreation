using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("Movement!");
    }

    // Update is called once per frame
    void Update()
    {
        // Keeping rb from falling over
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        // For turns
        float rate = 0;
        // For motion
        float speed = 0;
        // For jumps
        float power = 5;

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            rate = -60;
            transform.Rotate(0, rate * Time.deltaTime, 0);
            Debug.Log("Left!");
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            rate = 60;
            transform.Rotate(0, rate * Time.deltaTime, 0);
            Debug.Log("Right!");
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            speed = 5;
            transform.Translate(Time.deltaTime * speed * Vector3.forward);
            Debug.Log("Forward!");
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
            speed = -5;
            transform.Translate(Time.deltaTime * speed * Vector3.forward);
            Debug.Log("Back!");
        }
        else
        {
            // Freeze rotation if not in use
            rb.constraints |= RigidbodyConstraints.FreezeRotationY;
        }

        if(Keyboard.current.spaceKey.isPressed){
            transform.Translate(Vector3.up * Time.deltaTime * power);
            Debug.Log("Jump!");
        }
    }
}
