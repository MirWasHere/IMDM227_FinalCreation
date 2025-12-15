using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeVideo : MonoBehaviour
{
    VideoPlayer video;
    // AudioSource to play song from
    AudioSource audSource;
    // Video clip
    public VideoClip clip;
    // Scene name the video will change into upon completion
    public string sceneName;
    // For timing playing jingle bells; wait 16 seconds
    float timerStart = 16f;
    // After song is playing, check when to change to completion screen
    float timerChangeImage = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Getting audio and video sources
        audSource = GetComponent<AudioSource>();
        video = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        // When the video has stopped playing, change scenes
        if(string.Compare(sceneName, "EndVideo") == 0)
        {
            // Start a timer
            if (timerStart > 0) 
            {
                timerStart -= Time.deltaTime;
            }
            // After timer, play song
            else if(!audSource.isPlaying)
            {
                Debug.Log("Playing jingle bells!");
                audSource.Play();
            }
            // Once song is playing, wait to change image
            else if(timerChangeImage > 0)
            {
                timerChangeImage -= Time.deltaTime;
            }
            // Changing video source aftertime
            else
            {
                video.clip = clip;
                video.isLooping = true;
            }
        }
        else if(!video.isPlaying)
        {
            Debug.Log("end beginning scene.");
            SceneManager.LoadScene(sceneName);
        }
    }


}
