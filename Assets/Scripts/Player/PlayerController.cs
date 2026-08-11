using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    private Vector2 moveInput;
    [SerializeField]
    private float moveSpeed = 5f;

    void Awake()
    {
        inputActions = new InputSystem_Actions();
    }
    void OnEnable()
    {
        inputActions.Enable();

    }
    void OnDisable()
    {
        inputActions.Disable();
    }
    void Update()
    {
        moveInput = inputActions.Player.Move.ReadValue<Vector2>();

        Debug.Log("The Current input are X: "+ moveInput.x + "y:" + moveInput.y);

        Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y);

        transform.Translate(movement * moveSpeed * Time.deltaTime);
        
    }
}
