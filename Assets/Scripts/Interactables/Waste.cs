using TMPro;
using UnityEngine;

public class Waste : MonoBehaviour, IIteractable
{
    public TextMeshProUGUI interactionText;

    void Start()
    {
        //interactionText = GameObject.Find("InteractionText").GetComponent<TextMeshProUGUI>();
        if(interactionText!= null)
        {
            interactionText.gameObject.SetActive(false);
        }
    }
    public void ShowMessage()
    {
        if(interactionText!= null)
        {
            interactionText.gameObject.SetActive(true);
        }
        //Debug.Log("Press E to interact");
    }
    
    public void HideMessage()
    {
        if(interactionText!= null)
        {
            interactionText.gameObject.SetActive(false);
        }
        //Debug.Log("Message is hidden!!");
    }
    public void Interact()
    {
        //Debug.Log("Waste Collected");
        GameManager.Instance.AddWaste();
        interactionText.gameObject.SetActive(false);
        Destroy(gameObject);
        
    }
}
