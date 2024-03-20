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
    }

    public void UpdateTexts()
    {
        _healthText.text = $"Health: {_playerProperties.Health}";
        _scoreText.text = $"Score: {_playerProperties.Score}";
    }
}
