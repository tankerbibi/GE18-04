using UnityEngine;
using UnityEngine.Events;

public class BeInteracted : MonoBehaviour
{
    [SerializeField] private UnityEvent Interact;

    public void DoInteract()
    {
        Interact.Invoke();
    }
}
