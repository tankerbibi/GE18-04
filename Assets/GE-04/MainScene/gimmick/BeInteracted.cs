using UnityEngine;
using UnityEngine.Events;

public class BeInteracted : MonoBehaviour
{
    [SerializeField] private UnityEvent Interact;
    private GameObject player;
    public void DoInteract()
    {
        Interact.Invoke();
    }

    public void SetPlayer(GameObject p)
    {
        player = p;
    }

    public GameObject GetPlayer()
    {
        return player;
    }
}
