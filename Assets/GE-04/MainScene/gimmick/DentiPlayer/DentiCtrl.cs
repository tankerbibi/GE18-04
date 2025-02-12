using UnityEngine;
using UnityEngine.InputSystem;

public class DentiCtrl : MonoBehaviour
{
    private Rigidbody rb;
    private float move = 0.0f;
    private float posNeg = 0.0f;
    [SerializeField] private float rotationSpeed = 5.0f;
    [SerializeField] private float movementSpeed = 5.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        rb.linearVelocity = transform.rotation * new Vector3(0, rb.linearVelocity.y, move);
        transform.Rotate(0.0f, posNeg * Time.deltaTime, 0.0f);
    }
}
