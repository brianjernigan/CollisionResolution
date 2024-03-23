//////////////////////////////////////////////
//Assignment/Lab/Project: Collision Resolution
//Name: Brian Jernigan
//Section: SGD.213.2172
//Instructor: Brian Sowers
//Date: 03/25/2024
/////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private float _rotationSpeed = 100f;
    private void Update()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * _rotationSpeed));
    }
}
