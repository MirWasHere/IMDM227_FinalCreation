using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Movement!");
    }

    // Update is called once per frame
    void Update()
    {
        // For turns
        float rate = 0;
        // For motion
        float speed = 0;

        if(Keyboard.current.leftArrowKey.isPressed)
        {
            rate = -60;
            transform.Rotate(0, rate * Time.deltaTime, 0);
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            rate = 60;
            transform.Rotate(0, rate * Time.deltaTime, 0);
        }

        if (Keyboard.current.upArrowKey.isPressed)
        {
            speed = 5;
            transform.Translate(Time.deltaTime * speed * Vector3.forward);
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            speed = -5;
            transform.Translate(Time.deltaTime * speed * Vector3.forward);
        }
    }
}
