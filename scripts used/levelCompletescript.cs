using UnityEngine;
using UnityEngine.SceneManagement;

public class levelCompletescript : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
