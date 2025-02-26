using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject EUI = null;
    [SerializeField] private GameObject dentiUI = null;
    private Collider saved = null;
    private BeInteracted beInteracted = null;
    private CtrlFinalButton ctrlFinalButton = null;
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
                Debug.Log("Triggered");
                saved = other;
                EUI.SetActive(true);
                beInteracted = other.GetComponent<BeInteracted>();
            }
            else if(other.GetComponent<CtrlFinalButton>())
            {
                saved = other;
                ctrlFinalButton = other.GetComponent<CtrlFinalButton>();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (playerInput.inputIsActive)
        {
            if (other == saved)
            {
                if (beInteracted != null)
                {
                    EUI.SetActive(false);
                    saved = null;
                    beInteracted = null;
                }

                if(ctrlFinalButton != null)
                {
                    saved = null;
                    ctrlFinalButton = null;
                }
            }
        }
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if(beInteracted != null)
        {
            beInteracted.SetPlayer(this.gameObject); //プレイヤーの情報を伝える
            beInteracted.DoInteract(); //
            EUI.SetActive(false);
            dentiUI.SetActive(true);
            saved = null;
            ctrlFinalButton = null;
            beInteracted = null;
        }
    }
    public void OnCompleteF(InputAction.CallbackContext context)
    {
        if (ctrlFinalButton != null)
        {
            EUI.SetActive(false);
            saved = null;
            ctrlFinalButton.ActivateFinalButton();
        }
    }
}
