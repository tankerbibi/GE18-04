using UnityEngine;
using UnityEngine.InputSystem;

public class DentiCtrl : MonoBehaviour
{
    private Rigidbody rb;
    private float move = 0.0f;
    private float posNeg = 0.0f;
    private InputCtrl inputCtrl;
    private PlayerInput playerInput;

    [SerializeField] private float rotationSpeed = 45.0f;
    [SerializeField] private float movementSpeed = 20.0f;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<float>();
        move *= movementSpeed;
    }
    public void OnRotate(InputAction.CallbackContext context)
    {
        posNeg = context.ReadValue<float>();
        posNeg *= rotationSpeed;
    }
    private void Update()
    {
        if (playerInput.inputIsActive)
        {
            rb.linearVelocity = transform.rotation * new Vector3(0, rb.linearVelocity.y, move);
            transform.Rotate(0.0f, posNeg * Time.deltaTime, 0.0f);
        }
    }
}
