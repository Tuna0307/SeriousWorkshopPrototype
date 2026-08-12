using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int collectedWaste {get; private set;}

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddWaste()
    {
        collectedWaste++;
        Debug.Log("Waste collected current count" + collectedWaste);
    }


}
