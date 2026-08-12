using UnityEngine;

public class InteractionZone : MonoBehaviour
{
    private IIteractable currentInteractable;
    private void OnTriggerEnter(Collider other)
    {
        
        IIteractable interactable = other.GetComponent<IIteractable>();
        if(interactable != null)
        {
            currentInteractable = interactable;
            Debug.Log("Player approaching" + other.gameObject.name);
            interactable.ShowMessage();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
        IIteractable interactable = other.GetComponent<IIteractable>();
        if(interactable == currentInteractable && currentInteractable != null)
        {
            Debug.Log("Player is away from" + other.gameObject.name);
            currentInteractable.HideMessage();
            currentInteractable = null;
        }
  
        
    }
    public void Interact()
    {
        if (currentInteractable != null)
        {
            currentInteractable.Interact();
        }
            
    }
}
