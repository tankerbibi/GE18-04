using UnityEngine;

public class CheckDentiIn : MonoBehaviour
{
    private bool DentiIn = false;
    private Collider minus = null;
    [SerializeField] private Material correctM;
    [SerializeField] private SetMaterial setMaterial1;
    [SerializeField] private SetMaterial setMaterial2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Minus")
        {
            minus = other;
            setMaterial1.ChangeMaterial(correctM);
            setMaterial2.ChangeMaterial(correctM);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other == minus)
        {
            minus = null;
            setMaterial1.UndoMaterial();
            setMaterial2.UndoMaterial();
        }
    }

    public bool GetDentiIn()
    {
        return DentiIn;
    }
}
