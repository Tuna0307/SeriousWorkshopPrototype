using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI wasteCountText;

    // Update is called once per frame
    void Update()
    {
        int collectedWaste = GameManager.Instance.collectedWaste;
        wasteCountText.text = $"Waste: {collectedWaste}";
    }
}
