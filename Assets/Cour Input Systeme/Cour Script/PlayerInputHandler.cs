using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private InputSystem_Gun _inputSystemGun;

    private void Start()
    {
        _inputSystemGun = new InputSystem_Gun();
        //_inputSystemGun.Player.Shoot.performed += Shoot();
    }

    private void Update()
    {
        if (Keyboard.current.zKey.wasPressedThisFrame)
        {
            Debug.Log("Go forward");
        }
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Shoot");
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log($"Move input value : {context.ReadValue<Vector2>()}");
        }
    }
}
