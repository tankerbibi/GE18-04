using System;
using UnityEngine;

public class TamasiiMove : MonoBehaviour
{
    private Vector3 initLocalPos;
    private Vector3 initPos;
    private Transform followTransform;
    [SerializeField] private float upDownSpeed = 5.0f;
    [SerializeField] private float moveWidth;
    [SerializeField] private float followRate = 2.0f;
    

    // Update is called once per frame

    private void Start()
    {
        followTransform = null;
        initPos = transform.position;
        initLocalPos = transform.localPosition;
    }
    void Update()
    {
        float sin = Mathf.Sin(Time.time * upDownSpeed) * moveWidth;
        transform.localPosition = new Vector3(initLocalPos.x, initLocalPos.y + sin, initLocalPos.z);
        if(followTransform == null) //ÉtÉHÉçÅ[ëŒè€Ç™ë∂ç›ÇµÇ»Ç¢Ç∆Ç´
        {
            transform.position = Vector3.MoveTowards(transform.position, initPos, followRate * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, followTransform.position, followRate * Time.deltaTime);
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
