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
