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
using UnityEngine.Serialization;

public class Raycaster : MonoBehaviour
{
    [SerializeField] private Camera _mainCam;
    [SerializeField] private LayerMask _destructibleObjects;

    [SerializeField] private AudioSource _laserAudio;
    [SerializeField] private AudioSource _explosionAudio;

    private PlayerProperties _playerProperties;

    private void Start()
    {
        _playerProperties = FindObjectOfType<PlayerProperties>();
    }
    
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (!Input.GetMouseButtonDown(0) || _playerProperties.IsDead) return;
        var ray = _mainCam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hit, Mathf.Infinity, _destructibleObjects))
        {
            _explosionAudio.Play();
            Destroy(hit.collider.gameObject);
        }
        else
        {
            _laserAudio.Play();
        }
    }
}
