using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class DentiFlip : MonoBehaviour
{
    [SerializeField] private float rate = 0.5f;
    [SerializeField] private Vector3 Rotate = new Vector3(0, 0, 180);
    private Quaternion initRotation;
    private Quaternion targetRotation;

    public bool fliped = false;
    private void Start()
    {
        initRotation = transform.rotation;
        targetRotation = Quaternion.Euler(Rotate) * initRotation;
    }
    private void Update()
    {
        DoFlip();
    }
    public void OnFlip(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (fliped)
            {
                transform.rotation = initRotation;
            }
            else
            {
                transform.rotation = targetRotation;
            }
            fliped = !fliped;
        }
    }
    private void DoFlip()
    {
        if (fliped)
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rate);
        }
        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, initRotation, rate);
        }
    }
}
