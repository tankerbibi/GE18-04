using UnityEngine;

public class ChangeButtonMat : MonoBehaviour
{
    private Material initM;
    [SerializeField]private Material targetMaterial;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        initM = meshRenderer.material;
    }

    public void ChangeMaterial()
    {
        meshRenderer.material = targetMaterial;
        Invoke("UndoMaterial", 1.0f);
    }

    private void UndoMaterial()
    {
        meshRenderer.material = initM;
    }
}
