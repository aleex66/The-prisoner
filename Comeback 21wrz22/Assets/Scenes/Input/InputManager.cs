using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager _instance;

    public static InputManager Instance 
    {
        get
        {
            return _instance;
        }
    }
    private PlayerControls _playerControls;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);   
        }
        else
        {
            _instance = this;
        }
        _playerControls = new PlayerControls();
        Cursor.visible = false;
    }
    private void OnEnable()
    {
        _playerControls.Enable();
    }
    private void OnDisable()
    {
        _playerControls.Disable();
    }
    public Vector2 GetPlayerMovement()
    {
        return _playerControls.Player.Movement.ReadValue<Vector2>();
    }
    public Vector2 GetMouseDelta()
    {
        return _playerControls.Player.Look.ReadValue<Vector2>();
    }
    public bool PlayerJumpedThisFrame(string jump)
    {
        return _playerControls.Player.Jump.triggered;
    }
}