using UnityEngine;
using UnityEngine.InputSystem;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject EUI = null;
    private Collider saved = null;
    private void Start()
    {
        EUI.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "gimmick")
        {
            EUI.SetActive(true);
            saved = other;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other == saved)
        {
            EUI.SetActive(false);
            saved = null;

        }
    }
    public void OnInteract(InputAction.CallbackContext context)
    {
        if(saved != null)
        {
            BeInteracted beInteracted = saved.GetComponent<BeInteracted>();
            beInteracted.SetPlayer(this.gameObject); //ƒvƒŒƒCƒ„[‚Ìî•ñ‚ğ“`‚¦‚é
            beInteracted.DoInteract(); //
        }
    }
}
