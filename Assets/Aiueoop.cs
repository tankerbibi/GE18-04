using UnityEngine;

public class Aiueoop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GameController")
        {
            Debug.Log("めり込んだぜ");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "GameController")
        {
            Debug.Log("衝突したぜ");
        }
    }

}
