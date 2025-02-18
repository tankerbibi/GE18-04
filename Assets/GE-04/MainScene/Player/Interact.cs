using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject EUI = null;
    private Collider saved = null;
    private BeInteracted beInteracted = null;
    private void Start()
    {
        EUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered");
        if (other.GetComponent<BeInteracted>())
        {
            
            saved = other;
            EUI.SetActive(true);
            beInteracted = other.GetComponent<BeInteracted>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other == saved)
        {
            EUI.SetActive(false);
            saved = null;
            beInteracted = null;

        }
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if(saved != null)
        {
            beInteracted.SetPlayer(this.gameObject); //ÉvÉåÉCÉÑÅ[ÇÃèÓïÒÇì`Ç¶ÇÈ
            beInteracted.DoInteract(); //
        }
    }
}
