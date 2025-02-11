using UnityEngine;

public class TamasiiMove : MonoBehaviour
{
    private Vector3 pos;
    [SerializeField] private float movementSpeed = 5.0f;
    [SerializeField] private float moveWidth;

    // Update is called once per frame

    private void Start()
    {
        pos = transform.localPosition;
    }
    void Update()
    {
        float sin = Mathf.Sin(Time.time * movementSpeed) * moveWidth;
        transform.localPosition = new Vector3(pos.x, pos.y + sin, pos.z);
    }
}
