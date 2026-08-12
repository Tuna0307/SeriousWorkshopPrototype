using UnityEngine;

public class Waste : MonoBehaviour, IIteractable
{
    public void ShowMessage()
    {
        Debug.Log("Press E to interact");
    }
    
    public void HideMessage()
    {
        Debug.Log("Message is hidden!!");
    }
    public void Interact()
    {
        Debug.Log("Waste Collected");
    }
}
