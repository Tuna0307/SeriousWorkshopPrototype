using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField]
    private UIManager uiManager;

    public int collectedWaste {get; private set;}
    private GameState currentState;
    private int requiredWaste;

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
    void Start()
    {
        SetGameState(GameState.Playing);
        requiredWaste = 1;
    }

    public void AddWaste()
    {
        collectedWaste++;
        //Debug.Log("Waste collected current count" + collectedWaste);
        if(collectedWaste >= requiredWaste)
        {
            SetGameState(GameState.Win);
            uiManager.ShowWinPanel();
            
        }
    }

    void SetGameState(GameState state)
    {
        currentState = state;
    }
    public GameState GetGameState()
    {
        return currentState;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("ParkScene");
    }


}
