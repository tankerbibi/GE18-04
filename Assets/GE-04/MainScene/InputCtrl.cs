using System.ComponentModel.Design;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCtrl : MonoBehaviour
{
    [SerializeField] private bool inputLocked = true;
    private PlayerInput playerInput;
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        if(inputLocked == true)
        {
            LockInput();
        }
    }
    public void UnlockInput()
    {
        inputLocked = false;
        playerInput.ActivateInput();
    }
    public void LockInput()
    {
        inputLocked = true;
        playerInput.DeactivateInput();
    }
}
