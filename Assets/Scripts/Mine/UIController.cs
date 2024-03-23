//////////////////////////////////////////////
//Assignment/Lab/Project: Collision Resolution
//Name: Brian Jernigan
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 03/25/2024
/////////////////////////////////////////////

using System;
using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    [Header("HUD Texts")]
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;

    [Header("Game Over")]
    [SerializeField] private GameObject _gameOverPanel;

    [Header("Win")] 
    [SerializeField] private GameObject _winPanel;

    private PlayerProperties _playerProperties;

    private void Start()
    {
        _playerProperties = FindObjectOfType<PlayerProperties>();
        SubscribeEvents();
    }

    private void OnDisable()
    {
        UnsubscribeEvents();
    }

    private void UpdateHealthText(int currentHealth)
    {
        _healthText.text = $"Health: {currentHealth}";
    }

    private void UpdateScoreText(int currentScore)
    {
        _scoreText.text = $"Score: {currentScore}";
    }

    private void HandlePlayerDeath()
    {
        _gameOverPanel.SetActive(true);
    }

    private void HandlePlayerWin()
    {
        _winPanel.SetActive(true);
    }

    public void OnClickPlayAgainButton()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OnClickQuitButton()
    {
        Application.Quit();
    }

    private void SubscribeEvents()
    {
        _playerProperties.OnHealthChanged += UpdateHealthText;
        _playerProperties.OnScoreChanged += UpdateScoreText;
        _playerProperties.OnDeath += HandlePlayerDeath;
        _playerProperties.OnWin += HandlePlayerWin;
    }

    private void UnsubscribeEvents()
    {
        _playerProperties.OnHealthChanged -= UpdateHealthText;
        _playerProperties.OnScoreChanged -= UpdateScoreText;
        _playerProperties.OnDeath -= HandlePlayerDeath;
        _playerProperties.OnWin -= HandlePlayerWin;
    }
}
