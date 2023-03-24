using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int playerLives = 3;  // Oyuncunun can sayısı
    public GameObject startUI;  // Başlangıçta görünen UI objesi

    private LevelManager levelManager; 

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();  // Level Manager scriptine eriş
        //Time.timeScale = 0f;  // Oyun başlamadan durdur
        startUI.SetActive(true);  // Start UI'sını aktif hale getir
    }

    private void Update()
    {
        if (playerLives <= 0)
        {
            levelManager.GameOver();  // Oyun bittiyse Game Over ekranını göster
        }
    }

    public void StartGame()
    {
        Time.timeScale = 1f;  // Oyun zamanlayıcısını tekrar başlat
        startUI.SetActive(false);  // Başlangıç UI'sını devre dışı bırak
    }

    public void PlayerDied()
    {
        playerLives--;  // Can sayısını düşür
        levelManager.RestartLevel();  // Level'i yeniden başlat
    }

    public void QuitGame()
    {
        levelManager.QuitGame();  // Uygulamadan çık
    }
}
