using UnityEngine;

public class DentiBhv : MonoBehaviour //�d�r��ڲ԰�̍��v���C���[
{
    [SerializeField]private BeInteracted beInteracted;
    [SerializeField] private float setCameraDelay = 0.7f;
    private InputCtrl inputCtrl;
    private GameObject tamasiiPlayer = null;

    private void Start()
    {
        inputCtrl = GetComponent<InputCtrl>();
    }

    public void PlayDentiBhv() //��������v���C���[�ɖ߂�����
    {
        tamasiiPlayer = beInteracted.GetPlayer();
        tamasiiPlayer.transform.Find("Tamasii").gameObject.GetComponent<TamasiiMove>().SetFollowTransform(transform);

        //tamasiiPlayer.GetComponent<TamasiiMove>().SetFollowTransform(transform); //�����f���Ǐ]���ύX

        tamasiiPlayer.GetComponent<InputCtrl>().LockInput(); //���͂����b�N

        inputCtrl.UnlockInput(); //���͂����b�N����

        Invoke("SetCamera", setCameraDelay);
    }
    private void SetCamera()
    {
        transform.Find("Camera").gameObject.SetActive(true); //�J������ύX
        tamasiiPlayer.transform.Find("Camera").gameObject.SetActive(false);
        
    }
}
