using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [Header("HUD Texts")]
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;

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

    private void SubscribeEvents()
    {
        _playerProperties.OnHealthChanged += UpdateHealthText;
        _playerProperties.OnScoreChanged += UpdateScoreText;
    }

    private void UnsubscribeEvents()
    {
        _playerProperties.OnHealthChanged -= UpdateHealthText;
        _playerProperties.OnScoreChanged -= UpdateScoreText;
    }
}
