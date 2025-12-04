using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int points = 10;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectiblesManager.Instance.AddCollectible();
            Destroy(gameObject);
        }
    }
}