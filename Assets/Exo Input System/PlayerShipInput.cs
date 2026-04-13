using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShipInput : MonoBehaviour
{
    private ExoInputActions _newInputSystemActions;

    [SerializeField]
    private float _moveSpeed = 5f;

    private float _activeMoveSpeed = 5f;

    private Vector2 _moveInput;
    
    [SerializeField]
    private GameObject _bullet;

    private float dashSpeed = 10f;
    private float _dashLength = 0.5f;
    private float _dashCooldown = 1f;
    private float _dashCounter;
    private float _dashCoolCounter;

    private void Start()
    {
        _newInputSystemActions = new ExoInputActions();
    }

    private void Update()
    {
        transform.Translate(_moveInput * Time.deltaTime * _moveSpeed);
        
        if (_dashCounter > 0)
        {
            _dashCounter -= Time.deltaTime;

            if (_dashCounter <= 0)
            {
                _activeMoveSpeed = _moveSpeed;
                _dashCoolCounter = _dashCooldown;
            }
        }

        if (_dashCoolCounter > 0) 
        {
            _dashCoolCounter -= Time.deltaTime;
        }
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Instantiate(_bullet, transform.position, transform.rotation);
            Debug.Log("Shoot");
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            _moveInput = context.ReadValue<Vector2>();
        }

        if (context.canceled)
        {
            _moveInput = Vector2.zero;
        }
    }

    public void Dash(InputAction.CallbackContext context)
    {
        if (context.performed) 
        {
            if (_dashCoolCounter <=0 && _dashCounter <= 0)
            {
                _activeMoveSpeed = dashSpeed;
                _dashCounter = _dashLength;
            }
        }
    }
}
