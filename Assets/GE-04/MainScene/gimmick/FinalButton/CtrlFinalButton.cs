using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Splines.Interpolators;
using UnityEngine.SceneManagement;

public class CtrlFinalButton : MonoBehaviour
{
    [SerializeField] private CheckDentiIn ok1;
    [SerializeField] private CheckDentiIn ok2;
    [SerializeField] private CheckDentiIn ok3;
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private GameObject targetCamera;
    [SerializeField] private float moveRate = 2.0f;
    [SerializeField] private float rotateRate = 4.0f;
    [SerializeField] private float fovChangeRate = 6.0f;
    [SerializeField] private ChangeButtonMat changeButtonMat;
    private bool flg = false;
    private bool flg2 = false;
    private Camera pCamera;
    private Camera tCamera;

    private void Start()
    {
        pCamera = playerCamera.GetComponent<Camera>();
        tCamera = targetCamera.GetComponent<Camera>();
    }
    public void ActivateFinalButton()
    {
        changeButtonMat.ChangeMaterial();

        if (ok1.DentiIn &&
            ok2.DentiIn &&
            ok3.DentiIn)
        {
            flg = true;
        }
    }

    public void Update()
    {
        if(flg)
        {
            playerCamera.transform.position = Vector3.Slerp(playerCamera.transform.position, targetCamera.transform.position, moveRate * Time.deltaTime);
            playerCamera.transform.rotation = Quaternion.RotateTowards(playerCamera.transform.rotation, targetCamera.transform.rotation, rotateRate * Time.deltaTime);
            if(flg2)
            {
                pCamera.fieldOfView = Mathf.Lerp(pCamera.fieldOfView, tCamera.fieldOfView, fovChangeRate * Time.deltaTime);
            }
            else
            {
                Invoke("StartFOVChange", 2.0f);
                Invoke("MoveScene", 3.0f);
            }

        }
    }

    private void StartFOVChange()
    {
        flg2 = true;
    }
    private void MoveScene()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
