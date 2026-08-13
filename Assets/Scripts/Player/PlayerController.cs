using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InputSystem_Actions inputActions;
    private Rigidbody rb;
    //private CharacterController controller;
    
    //movement actions
    private Vector2 moveInput;
    [SerializeField]
    private float moveSpeed = 5f;
    private float rotationSpeed = 5f;

    private Vector3 movement = Vector3.zero;

    //Interaction action variable
    [SerializeField]
    private InteractionZone interactionZone;



    void Awake()
    {
        inputActions = new InputSystem_Actions();
        //controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
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
        if(GameManager.Instance.GetGameState() != GameState.Playing)
            return;
        moveInput = inputActions.Player.Move.ReadValue<Vector2>();

        //Debug.Log("The Current input are X: "+ moveInput.x + "y:" + moveInput.y);

        movement = new Vector3(moveInput.x, 0f, moveInput.y);
        /*
        if(movement.magnitude > 0.1f)
        {
            //transform.Translate(movement * moveSpeed * Time.deltaTime);

            //Movement Via Character Controller
            //controller.Move(movement * moveSpeed * Time.deltaTime);

            Quaternion targetRotation = Quaternion.LookRotation(movement);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime );
        }
        */

        if(inputActions.Player.Interact.WasPressedThisFrame())
        {
            //Call the interact function
            interactionZone.Interact();

        }


    }
    void FixedUpdate ()
    {
       if(movement.magnitude > 0.1f)
       {
         rb.linearVelocity = new Vector3(
            moveInput.x * moveSpeed,
            rb.linearVelocity.y,
            moveInput.y * moveSpeed);

        Quaternion targetRotation = Quaternion.LookRotation(movement);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime );
       }


    }
    
    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collision with: " + collision.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter a trigger zone: " + other.gameObject.name);
    }


    
}



