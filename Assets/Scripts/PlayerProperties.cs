using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    private int Health { get; set; }
    private int Score { get; set; }
    
    public bool IsDead { get; set; }
    
    public event Action<int> OnHealthChanged;
    public event Action OnDeath;

    public event Action<int> OnScoreChanged;
    public event Action OnWin;
    
    [Header("Audio")] 
    [SerializeField] private AudioSource _hurtAudio;
    [SerializeField] private AudioSource _coinAudio;
    
    private void Start()
    {
        Health = 10;
    }
    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Spike"))
        {
            TakeDamage(1);
            Destroy(hit.collider.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            IncreaseScore(1);
            Destroy(other.gameObject);
        }
    }

    private void TakeDamage(int damage)
    {
        Health -= damage;
        Health = Mathf.Max(Health, 0);
        OnHealthChanged?.Invoke(Health);

        _hurtAudio.time = 0.4f;
        _hurtAudio.Play();

        if (Health == 0)
        {
            IsDead = true;
            OnDeath?.Invoke();
        }
    }

    private void IncreaseScore(int amount)
    {
        Score += amount;
        OnScoreChanged?.Invoke(Score);

        _coinAudio.time = 0.3f;
        _coinAudio.Play();

        if (Score == 10)
        {
            OnWin?.Invoke();
        }
    }
}
