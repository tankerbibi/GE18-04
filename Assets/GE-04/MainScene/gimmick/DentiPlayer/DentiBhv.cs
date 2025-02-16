using UnityEngine;

public class DentiBhv : MonoBehaviour //�d�r��ڲ԰�̍��v���C���[
{
    private BeInteracted beInteracted;
    [SerializeField] private float setCameraDelay = 0.7f;
    private void Start()
    {
        beInteracted = GetComponent<BeInteracted>();
    }
    public void PlayDentiBhv() //��������v���C���[�ɖ߂�����
    {
        GameObject TamasiiPlayer = beInteracted.GetPlayer();

        GetComponent<InputCtrl>().UnlockInput();
        TamasiiPlayer.GetComponent<InputCtrl>().UnlockInput(); //���͂����b�N

        TamasiiPlayer.GetComponent<TamasiiMove>().SetFollowTransform(transform); //�����f���Ǐ]���ύX

        Invoke("SetCamera" , setCameraDelay);
    }
    private void SetCamera(GameObject TamasiiPlayer)
    {
        transform.Find("Camera").gameObject.SetActive(false); //�J������ύX
        TamasiiPlayer.transform.Find("Camera").gameObject.SetActive(true);
    }
}
