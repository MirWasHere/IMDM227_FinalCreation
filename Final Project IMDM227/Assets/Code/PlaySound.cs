using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{
    // AudioSource to play note from
    AudioSource audSource;


    // Array of notes
    public AudioClip[] clips;

    // Tracks index, will be the same as collectible count (minus 1)
    int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Getting audio source
        audSource = GetComponent<AudioSource>();
        
    }

    // When the object is collided with
    private void OnTriggerEnter(Collider other)
    {
        // if(other.tag == "Collectible")
        // {
        // }

        // Getting next note from array
        audSource.clip = clips[index];
        Debug.Log("note played: " + audSource.clip);
        // Play note...
        audSource.Play();
        Debug.Log("Playing note...");

        // Increment index
        index ++;
        // Just in case more collectibles are available than in array
        if(index >= clips.Length)
        {
            index = 0;
        }
        
    }
}
