using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour
{
    AudioSource audSource;

    private IEnumerator coroutine;

    public GameObject gameObj;
    PlayerMovement playMove;

    // Tracks index, will be the same as collectible count (minus 1)
    int index = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Reference to player object
        gameObj = GameObject.FindWithTag("Player");
        // Getting a reference to player's playerMovement to get clips array
        playMove = GetComponent<PlayerMovement>();
        // Getting audio source
        audSource = GetComponent<AudioSource>();
        // intializing coroutine
        coroutine = WaitForNote(1.6f);
    }

    // When the object is collided with
    private void OnTriggerEnter(Collider other)
    {
        // // Getting next note from array
        // audSource.clip = playMove.clips[index];
        Debug.Log("note played: " + audSource.clip);
        // Play note...
        audSource.Play();
        Debug.Log("Playing note...");

        // Waiting for sound to finish before playing sound
        StartCoroutine(coroutine);

        // Increment index
        // index ++;
    }


    // Creating a coroutine, a way to pause code
    IEnumerator WaitForNote(float waitTime)
    {
        // Pausing for input seconds
        yield return new WaitForSeconds(waitTime);

        Debug.Log("Finished waiting, remove collectible.");
        // Setting object inactive
        gameObj.SetActive(false);
    }
}
