using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text fintext;

    public static GameManager instanse;
    [SerializeField] Text textScore;
    bool gameOver = false;
    int score = 0;
    private void Awake()
    {
        if (instanse == null)
        {
            instanse = this;
        }
    }
     public void GameOver()
    {
        gameOverPanel.SetActive(true);
        fintext.text = "Score: " + score.ToString();
        gameOver = true;
        GameObject.Find("EnemySpawn").GetComponent<EnemySpawner>().StopSpawning();
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            textScore.text = score.ToString();
        }
      
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}
