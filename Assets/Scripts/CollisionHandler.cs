using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private CharacterController _characterController;
    private PlayerProperties _playerProperties;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _playerProperties = GetComponent<PlayerProperties>();
    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if (hit.collider.CompareTag("Box"))
    //    {
    //        playerProperties.Health--;
    //        Debug.Log(playerProperties.Health);
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box")) 
        {
            Debug.Log("Box");
        }
    }
}
