using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTheLevel : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
