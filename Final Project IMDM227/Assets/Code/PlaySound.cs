using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{
    // AudioSource to play note from
    AudioSource audSource;

    // IEnumerator to time note
    private IEnumerator coroutine;

    // Array of notes
    public AudioClip[] clips;

    // Tracks index, will be the same as collectible count (minus 1)
    int index = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Getting audio source
        audSource = GetComponent<AudioSource>();
        // // intializing coroutine
        // coroutine = WaitForNote(1.6f);
    }

    // When the object is collided with
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectible")
        {
        }

        // Getting next note from array
        audSource.clip = clips[index];
        Debug.Log("note played: " + audSource.clip);
        // Play note...
        audSource.Play();
        Debug.Log("Playing note...");

        // // Waiting for sound to finish before playing sound
        // StartCoroutine(coroutine);

        // Increment index
        index ++;
        // Just in case more collectibles are available than in array
        if(index >= clips.Length)
        {
            index = 0;
        }
        
    }


    // Necessary if PlaySound is attached to collectibles, otherwise unecessary
    // // Creating a coroutine to pause code while note plays
    // IEnumerator WaitForNote(float waitTime)
    // {
    //     // Pausing for input seconds
    //     yield return new WaitForSeconds(waitTime);

    //     Debug.Log("Finished waiting");
    // }
}
