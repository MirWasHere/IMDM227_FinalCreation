using UnityEngine;
using TMPro;

public class CollectiblesCount : MonoBehaviour
{
    public TextMeshProUGUI countText;

    private void Update()
    {
        countText.text = "Music Notes: " + CollectiblesManager.Instance.collectiblesCount;
    }
}
