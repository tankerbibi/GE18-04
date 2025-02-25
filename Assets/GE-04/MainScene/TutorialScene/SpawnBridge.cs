using UnityEditor;
using UnityEngine;

public class SpawnBridge : MonoBehaviour
{
    [SerializeField] private GameObject bridge;
    [SerializeField] private GameObject toumeikabe;
    private Collider minus = null;
    public void MakeBridge(bool flg)
    {
        bridge.SetActive(flg);
        toumeikabe.SetActive(!flg);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Minus")
        {
            minus = other;
            MakeBridge(true);
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other == minus)
        {
            minus = null;
            MakeBridge(false);
        }
    }
}
