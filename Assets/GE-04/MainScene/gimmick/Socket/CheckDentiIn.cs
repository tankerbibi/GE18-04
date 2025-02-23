using System;
using UnityEngine;

public class CheckDentiIn : MonoBehaviour
{
    [NonSerialized]public bool DentiIn = false;
    private Collider minus = null;
    [SerializeField] private Material OnMaterial;
    [SerializeField] private SetMaterial setMaterialScript1;
    [SerializeField] private SetMaterial setMaterialScript2;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Minus")
        {
            minus = other;
            setMaterialScript1.ChangeMaterial(OnMaterial);
            setMaterialScript2.ChangeMaterial(OnMaterial);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other == minus)
        {
            minus = null;
            setMaterialScript1.UndoMaterial();
            setMaterialScript2.UndoMaterial();
        }
    }

    public bool GetDentiIn()
    {
        return DentiIn;
    }
}
