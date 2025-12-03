using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource audSource;
    AudioClip clip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Sound!");
        audSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When the object is collided with
    private void OnTriggerEnter(Collider other)
    {
        // SetActive(false);
    }
}
