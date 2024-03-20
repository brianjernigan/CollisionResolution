using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private PlayerProperties _playerProperties;
    private UIController _uiController;

    private void Start()
    {
        _playerProperties = GetComponent<PlayerProperties>();
        _uiController = FindObjectOfType<UIController>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.CompareTag("Box"))
        {
            _playerProperties.TakeDamage(1);
            _uiController.UpdateTexts();
            Destroy(hit.collider.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            _playerProperties.IncreaseScore(1);
            _uiController.UpdateTexts();
            Destroy(other.gameObject);
        }
    }
}
