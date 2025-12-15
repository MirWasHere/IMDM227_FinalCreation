using UnityEngine;

public class CollectibleAnimation : MonoBehaviour
{
    [SerializeField] float bobHeight = 0.25f;
    [SerializeField] float bobSpeed = 2f;

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float newY = startPos.y + Mathf.Sin(Time.time * bobSpeed) * bobHeight;
        transform.position = new Vector3(startPos.x, newY, startPos.z);
    }
}