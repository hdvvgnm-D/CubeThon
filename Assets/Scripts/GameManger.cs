using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameManger : MonoBehaviour
{
    public Transform playerTransform;
    public Text scoreText;
    bool IsGameOver = false;
    public GameObject winLevelUI;
    public void changePlayerScore()
    {
        scoreText.text = (playerTransform.position.z + 8.24).ToString("0");
    }
    public void EndGame()
    {
        if(IsGameOver==false)
        {
            Debug.Log("GAME OVER");
            IsGameOver = true;
            Invoke("RestartGame",1f);
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void WinGame()
    {
        FindObjectOfType<PlayerMove>().enabled = false;
        int num = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Win!!!"+num);
        winLevelUI.SetActive(true);
    }
}
