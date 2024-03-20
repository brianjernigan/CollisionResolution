using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProperties : MonoBehaviour
{
    public int Health { get; set; }
    public int Score { get; set; }

    private void Start()
    {
        Health = 10;
    }
}
