using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class DentiFlip : MonoBehaviour
{
    [SerializeField] private float rate = 2f;
    [SerializeField] private Vector3 Rotate = new Vector3(0, 0, 180);
    private Quaternion initRotation;
    private Quaternion targetRotation;
    private PlayerInput playerInput;

    [NonSerialized]public bool fliped = false;
    private void Start()
    {
        initRotation = transform.localRotation;
        targetRotation = Quaternion.Euler(Rotate) * initRotation;
        playerInput = GetComponentInParent<PlayerInput>();
    }
    private void Update()
    {
        if (playerInput.inputIsActive)
        {
            DoFlip();
        }
    }
    public void OnFlip(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (fliped) //à íuÇÃèâä˙âª
            {
                transform.localRotation = targetRotation;
            }
            else
            {
                transform.localRotation = initRotation;
            }
            fliped = !fliped;
        }
    }
    private void DoFlip()
    {
        if (fliped)
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, rate * Time.deltaTime);
        }
        else
        {
            transform.localRotation = Quaternion.Lerp(transform.localRotation, initRotation, rate * Time.deltaTime);
        }
    }
}
