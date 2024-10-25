using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI livesText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Button restartButton;

    [SerializeField] private Jogador player;
    private int score = 0;

    private void Awake()
    {
        instance = this;
        gameOverPanel.SetActive(false);
        restartButton.onClick.AddListener(() => SceneManager.LoadScene("Gameplay"));
        UpdateScore(0);
    }

    public void UpdateScore(int value)
    {
        score += value;
        scoreText.text = $"Kills: {score}";
    }

    public void UpdateLives(int value)
    {
        livesText.text = $"Lives: {value}";
    }

    public Transform GetPlayerPosition()
    {
        return player.transform;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        Debug.LogError("GAME OVER");
    }
}
