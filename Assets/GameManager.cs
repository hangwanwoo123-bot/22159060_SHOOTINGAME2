using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // 어디서든 접근 가능
    public GameObject gameOverPanel;    // 게임 오버 UI 담을 그릇

    private void Awake()
    {
        instance = this; 
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true); // 게임 오버 UI 켜기
        Time.timeScale = 0;            // 정지
    }

    public void RestartGame()
    {
        Time.timeScale = 1; // 시간 다시 흐르게
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 씬 재시작
    }
}
