using UnityEngine;
using UnityEngine.SceneManagement;
public class GotoMainScene : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag  == "Player")
        {
            SceneManager.LoadScene("MainScene2");
        }
    }
}
