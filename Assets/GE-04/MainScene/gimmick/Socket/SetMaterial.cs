using UnityEngine;

public class SetMaterial : MonoBehaviour
{
    private Material initM;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        initM = meshRenderer.material;
    }

    public void ChangeMaterial(Material correctM)
    {
        meshRenderer.material = correctM;
    }

    public void UndoMaterial()
    {
        meshRenderer.material = initM;
    }
}
