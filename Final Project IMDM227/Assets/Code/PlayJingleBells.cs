using UnityEngine;
using System.Collections;


// Plays jingle bells
public class PlayJingleBells : MonoBehaviour
{
    // AudioSource to play note from
    AudioSource audSource;
    // Array of notes
    /*
    * 0: C
    * 1: D
    * 2: E
    * 3: F
    * 4: G
    */
    public AudioClip[] clips;

    // IEnumerator to time note
    private IEnumerator coroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start will play notes
    void Start()
    {
        // Getting audio source
        audSource = GetComponent<AudioSource>();
        // One note is about 0.66... seconds long at 90 BPM
        coroutine = WaitForNote(0.66f);
        
        // Playing Song
        PlaySong();
    }


    void PlaySong()
    {
        // First & Second meeasure: E E E_ 
        audSource.clip = clips[2];

        // Repeated measure...
        for(int i = 0; i < 2; i ++)
        {
            // Repeated notes...
            for(int j = 0; j < 2; j ++)
            {
                // Play note...
                audSource.Play();
                Debug.Log("note played: " + audSource.clip);
                // Let it play out
                StartCoroutine(coroutine);
                // Stop note to be played again
                audSource.Stop();
            }

            // Play half note (hold for two beats)
            audSource.Play();
            Debug.Log("note played: " + audSource.clip);
            StartCoroutine(coroutine);
            StartCoroutine(coroutine);
            audSource.Stop();
        }

    }



    // Rest notes :0
    IEnumerator WaitForNote(float waitTime)
    {
        // Pausing for input seconds
        yield return new WaitForSeconds(waitTime);

        Debug.Log("Finished waiting");
    }
}
