using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI wasteCountText;
    [SerializeField]
    private GameObject HUD;
    [SerializeField]
    private GameObject WinPanel;

    
    void Start()
    {
        HUD.SetActive(true);
        WinPanel.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        int collectedWaste = GameManager.Instance.collectedWaste;
        wasteCountText.text = $"Waste: {collectedWaste}";
    }
    public void ShowWinPanel()
    {
        HUD.SetActive(false);
        WinPanel.SetActive(true);
    }

}
