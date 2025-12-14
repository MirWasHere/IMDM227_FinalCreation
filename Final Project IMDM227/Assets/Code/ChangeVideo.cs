using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ChangeVideo : MonoBehaviour
{
    VideoPlayer video;
    // Scene name the video will change into upon completion
    public string sceneName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        video = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        // When the video has stopped playing, change scenes
        if(!video.isPlaying)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
