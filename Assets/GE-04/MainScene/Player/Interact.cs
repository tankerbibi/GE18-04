using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject EUI = null;
    private Collider saved = null;
    private BeInteracted beInteracted = null;
    private PlayerInput playerInput;
    private void Start()
    {
        playerInput = GetComponent<PlayerInput>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (playerInput.inputIsActive)
        {
            if (other.GetComponent<BeInteracted>())
            {
                Debug.Log("IsTriggered");
                saved = other;
                EUI.SetActive(true);
                beInteracted = other.GetComponent<BeInteracted>();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (playerInput.inputIsActive)
        {
            if (other == saved)
            {
                Debug.Log("Isexit");
                EUI.SetActive(false);
                saved = null;
                beInteracted = null;
            }
        }
    }

    private void Update()
    {
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if(saved != null)
        {
            beInteracted.SetPlayer(this.gameObject); //ÉvÉåÉCÉÑÅ[ÇÃèÓïÒÇì`Ç¶ÇÈ
            beInteracted.DoInteract(); //
            EUI.SetActive(false);
        }
    }
}
