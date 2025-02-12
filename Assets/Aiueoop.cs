using UnityEngine;

public class Aiueoop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "GameController")
        {
            Debug.Log("ÇﬂÇËçûÇÒÇæÇ∫");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "GameController")
        {
            Debug.Log("è’ìÀÇµÇΩÇ∫");
        }
    }

}
