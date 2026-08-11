using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    private CharacterController controller;
    private Vector2 moveInput;
    [SerializeField]
    private float moveSpeed = 5f;
    private float rotationSpeed = 5f;

    void Awake()
    {
        inputActions = new InputSystem_Actions();
        controller = GetComponent<CharacterController>();
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

        if(movement.magnitude > 0.1f)
        {
            //transform.Translate(movement * moveSpeed * Time.deltaTime);

            controller.Move(movement * moveSpeed * Time.deltaTime);

            Quaternion targetRotation = Quaternion.LookRotation(movement);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime );
        }

        
    }
}
