using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed = 2.0f;
    [SerializeField]
    private float jumpHeight = 1.0f;
    [SerializeField]
    private float gravityValue = -9.81f;
    
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool _groundedPlayer;
    private InputManager _inputManager;
    private Transform _cameraTransform;
   

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        _inputManager = InputManager.Instance;
        _cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        _groundedPlayer = controller.isGrounded;
        if (_groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 movement = _inputManager.GetPlayerMovement();
        Vector3 move = new Vector3(movement.x, 0f, movement.y);
        move = _cameraTransform.forward * move.z + _cameraTransform.right * move.x;
        move.y = 0f;    
        controller.Move(move * Time.deltaTime * playerSpeed);
    
       /* if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
*/
        // Changes the height position of the player..
        if (_inputManager.PlayerJumpedThisFrame("Jump") && _groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
    
    
   /* [SerializeField] private float moveSpeed = 10f;
    Rigidbody rb;
    [SerializeField] private float rotationSpeed;
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("SIEMA");
    }
    void Update()
    {
        movement();
    }

    public void movement()
    {
        float xvalue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zvalue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        //transform.Translate(xvalue,0,zvalue);
        Vector3 movementDirection = new Vector3(xvalue, 0, zvalue);
        movementDirection.Normalize();
        transform.Translate(movementDirection * (moveSpeed * Time.deltaTime),Space.World);
        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }*/
}
