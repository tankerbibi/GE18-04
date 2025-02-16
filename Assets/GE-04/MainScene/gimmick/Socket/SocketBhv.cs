using UnityEngine;

public class SocketBhv : MonoBehaviour //ソケット⇔電池ﾌﾟﾚｲﾔｰ⇔魂プレイヤー
{
    private BeInteracted beInteracted;
    [SerializeField]private GameObject TamasiiPlayer;　//Inspecterで代入済み
    private TamasiiMove tamasiiMove;
    private void Start()
    {
        beInteracted = GetComponent<BeInteracted>();
        tamasiiMove = TamasiiPlayer.GetComponent<TamasiiMove>();
    }

    public void PlaySocketBhv() //操作を魂プレイヤーに戻す処理
    {
        GameObject dentiPlayer = beInteracted.GetPlayer();

        dentiPlayer.GetComponent<InputCtrl>().LockInput(); //入力をロック
        TamasiiPlayer.GetComponent<InputCtrl>().UnlockInput();

        dentiPlayer.transform.Find("Camera").gameObject.SetActive(false); //カメラを変更
        TamasiiPlayer.transform.Find("Camera").gameObject.SetActive(true);

        tamasiiMove.ResetFollowTransform();　//魂モデル追従先を変更
    }
}
