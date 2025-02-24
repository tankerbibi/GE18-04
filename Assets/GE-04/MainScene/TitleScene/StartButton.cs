using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainScene2");
    }
}
