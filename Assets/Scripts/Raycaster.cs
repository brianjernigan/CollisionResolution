using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Raycaster : MonoBehaviour
{
    [SerializeField] private Camera _mainCam;
    [SerializeField] private LayerMask _destructibleObjects;
    
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (!Input.GetMouseButtonDown(0)) return;
        var ray = _mainCam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hit, Mathf.Infinity, _destructibleObjects))
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
