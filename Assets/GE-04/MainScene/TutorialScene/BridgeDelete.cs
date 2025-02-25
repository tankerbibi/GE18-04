using UnityEngine;

public class BridgeDelete : MonoBehaviour
{
    [SerializeField] private GameObject Bridge;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Bridge.SetActive(false);
        }
    }
}
