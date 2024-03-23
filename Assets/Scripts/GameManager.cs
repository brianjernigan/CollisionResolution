using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PlayerProperties _playerProperties;
    private UIController _uiController;

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void OnDisable()
    {
        UnsubscribeEvents();
    }

    private void SubscribeEvents()
    {
        throw new NotImplementedException();
    }

    private void UnsubscribeEvents()
    {
        throw new NotImplementedException();
    }
}
