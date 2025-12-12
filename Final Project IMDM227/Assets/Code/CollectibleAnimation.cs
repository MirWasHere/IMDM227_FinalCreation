using UnityEngine;

public class CollectibleAnimation : MonoBehaviour
{
    // Rotation Rate
    float rotationRate = 20f;

    // Update is called once per frame
    void Update()
    {
        // Changing rotation
        transform.Rotate(0, rotationRate * Time.deltaTime, 0);
    }
}
