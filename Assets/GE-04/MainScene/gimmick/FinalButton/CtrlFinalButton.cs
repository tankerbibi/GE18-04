using UnityEngine;

public class CtrlFinalButton : MonoBehaviour
{
    [SerializeField] private CheckDentiIn ok1;
    [SerializeField] private CheckDentiIn ok2;
    [SerializeField] private CheckDentiIn ok3;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private Transform targetCameraPos;

    public void ActivateFinalButton()
    {
        if(ok1.DentiIn &&
            ok2.DentiIn &&
            ok3.DentiIn)
        {
        }
    }
}
