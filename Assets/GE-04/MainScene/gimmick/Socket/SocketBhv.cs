using UnityEngine;

public class SocketBhv : MonoBehaviour //�\�P�b�g�̓d�r��ڲ԰�̍��v���C���[
{
    private BeInteracted beInteracted;
    [SerializeField]private GameObject TamasiiPlayer;�@//Inspecter�ő���ς�
    private TamasiiMove tamasiiMove;
    private void Start()
    {
        beInteracted = GetComponent<BeInteracted>();
        tamasiiMove = TamasiiPlayer.GetComponent<TamasiiMove>();
    }

    public void PlaySocketBhv() //��������v���C���[�ɖ߂�����
    {
        GameObject dentiPlayer = beInteracted.GetPlayer();

        dentiPlayer.GetComponent<InputCtrl>().LockInput(); //���͂����b�N
        TamasiiPlayer.GetComponent<InputCtrl>().UnlockInput();

        dentiPlayer.transform.Find("Camera").gameObject.SetActive(false); //�J������ύX
        TamasiiPlayer.transform.Find("Camera").gameObject.SetActive(true);

        tamasiiMove.ResetFollowTransform();�@//�����f���Ǐ]���ύX
    }
}
