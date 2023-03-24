using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject gameOverUI; // Oyun bittiğinde gösterilecek UI objesi
    public GameObject startButton;
    
    private bool isGameStarted = false;

    private void Start()
    {
        gameOverUI.SetActive(false); // Game Over UI'sını başlangıçta devre dışı bırak 

        if (!isGameStarted)
        {
            startButton.SetActive(true);
        }
        else
        {
            startButton.SetActive(false);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1f; // Oyun zamanlayıcısını başlat
        
        isGameStarted = true;
        startButton.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0f; // Oyun zamanlayıcısını durdur
        gameOverUI.SetActive(true); // Game Over UI'sını aktif hale getir
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Aktif olan sahneyi yeniden yükle
        Time.timeScale = 1f; // Oyun zamanlayıcısını tekrar başlat
    }

    public void QuitGame()
    {
        Application.Quit(); // Uygulamadan çık
    }
}


