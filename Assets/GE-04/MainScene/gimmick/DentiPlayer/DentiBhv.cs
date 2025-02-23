using UnityEngine;

public class DentiBhv : MonoBehaviour //電池ﾌﾟﾚｲﾔｰ⇔魂プレイヤー
{
    [SerializeField] private GameObject dentiUI;
    [SerializeField] private BeInteracted beInteracted;
    [SerializeField] private float setCameraDelay = 0.7f;
    private InputCtrl inputCtrl;
    private GameObject tamasiiPlayer = null;

    private void Start()
    {
        inputCtrl = GetComponent<InputCtrl>();
    }

    public void PlayDentiBhv() //操作を魂プレイヤーに戻す処理
    {
        tamasiiPlayer = beInteracted.GetPlayer();
        tamasiiPlayer.transform.Find("Tamasii").gameObject.GetComponent<TamasiiMove>().SetFollowTransform(transform);

        //tamasiiPlayer.GetComponent<TamasiiMove>().SetFollowTransform(transform); //魂モデル追従先を変更

        tamasiiPlayer.GetComponent<InputCtrl>().LockInput(); //入力をロック

        inputCtrl.UnlockInput(); //入力をロック解除

        Invoke("SetCamera", setCameraDelay);
    }
    private void SetCamera()
    {
        tamasiiPlayer.transform.Find("TamasiiPlayerCamera").gameObject.SetActive(false);
        transform.Find("Camera").gameObject.SetActive(true); //カメラを変更
    }

    private void ResetCamera()
    {
        transform.Find("Camera").gameObject.SetActive(false); //カメラを変更
        tamasiiPlayer.transform.Find("TamasiiPlayerCamera").gameObject.SetActive(true);
    }
    public void ReversePlayDentiBhv()
    {
        tamasiiPlayer.transform.Find("Tamasii").gameObject.GetComponent<TamasiiMove>().ResetFollowTransform();

        inputCtrl.LockInput();

        tamasiiPlayer.GetComponent<InputCtrl>().UnlockInput();

        Invoke("ResetCamera", setCameraDelay);

        dentiUI.SetActive(false);
    }
}
