using UnityEngine;

public class SpawnBridge : MonoBehaviour
{
    [SerializeField] private GameObject bridge;

    public void MakeBridge()
    {
        bridge.SetActive(true);
    }
}
