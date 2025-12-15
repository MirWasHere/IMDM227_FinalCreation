using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectiblesManager : MonoBehaviour
{
    public static CollectiblesManager Instance;
    public int collectiblesCount = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void AddCollectible()
    {
        collectiblesCount++;
        Debug.Log("Collected: " + collectiblesCount);

        if(collectiblesCount >= 5)
        {
            SceneManager.LoadScene("EndVideo");
        }
    }
}