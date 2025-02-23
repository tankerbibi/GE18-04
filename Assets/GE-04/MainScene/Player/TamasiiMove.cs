using System;
using UnityEngine;

public class TamasiiMove : MonoBehaviour
{
    private Vector3 initLocalPos;
    [SerializeField]private Transform initTransform;
    private Transform followTransform;

    [SerializeField] private float upDownSpeed = 5.0f;
    [SerializeField] private float moveWidth;
    [SerializeField] private float followRate = 2.0f;

    // Update is called once per frame

    private void Start()
    {
        followTransform = null;
        initLocalPos = transform.localPosition;
    }
    void Update()
    {
        float sin = Mathf.Sin(Time.time * upDownSpeed) * moveWidth;
        
        if(followTransform == null) //ÉtÉHÉçÅ[ëŒè€Ç™ë∂ç›ÇµÇ»Ç¢Ç∆Ç´
        {
            transform.position = Vector3.MoveTowards(transform.position, initTransform.position, followRate * Time.deltaTime);
            transform.localPosition = new Vector3(transform.localPosition.x, initTransform.localPosition.y + sin, transform.localPosition.z);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, followTransform.position, followRate * Time.deltaTime);
            //transform.localPosition = new Vector3(transform.localPosition.x, initTransform.localPosition.y + sin, transform.localPosition.z);
        }

        
    }
    public void SetFollowTransform(Transform transform)
    {
        followTransform = transform;
    }
    public void ResetFollowTransform()
    {
        followTransform = null;
    }
}
