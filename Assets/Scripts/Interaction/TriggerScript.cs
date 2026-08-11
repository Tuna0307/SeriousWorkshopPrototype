using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject targetobject;

    void OnTriggerEnter(Collider other)
    {
        targetobject.SetActive(false);
    }

    void OnTriggerExit(Collider other)
    {
        targetobject.SetActive(true);
    }

}
