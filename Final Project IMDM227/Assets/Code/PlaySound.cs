using UnityEngine;

public class PlaySound : MonoBehaviour
{
    AudioSource audSource;
    AudioClip clip;

    public GameObject gameObj;
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
        audSource.Play(0);
        Debug.Log("Playing note...");
        gameObj.SetActive(false);
    }
}
