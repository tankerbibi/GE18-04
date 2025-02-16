using UnityEngine;

public class DentiBhv : MonoBehaviour //電池ﾌﾟﾚｲﾔｰ⇔魂プレイヤー
{
    private BeInteracted beInteracted;
    [SerializeField] private float setCameraDelay = 0.7f;
    private void Start()
    {
        beInteracted = GetComponent<BeInteracted>();
    }
    public void PlayDentiBhv() //操作を魂プレイヤーに戻す処理
    {
        GameObject TamasiiPlayer = beInteracted.GetPlayer();

        GetComponent<InputCtrl>().UnlockInput();
        TamasiiPlayer.GetComponent<InputCtrl>().UnlockInput(); //入力をロック

        TamasiiPlayer.GetComponent<TamasiiMove>().SetFollowTransform(transform); //魂モデル追従先を変更

        Invoke("SetCamera" , setCameraDelay);
    }
    private void SetCamera(GameObject TamasiiPlayer)
    {
        transform.Find("Camera").gameObject.SetActive(false); //カメラを変更
        TamasiiPlayer.transform.Find("Camera").gameObject.SetActive(true);
    }
}
