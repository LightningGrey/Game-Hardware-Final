using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{

    //raycast
    private GameObject _object;
    [SerializeField] private int _ray = 10;
    [SerializeField] private LayerMask _interactMask;
    [SerializeField] private Image crosshair;

    private void Update()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, forward, out hit, _ray, _interactMask.value))
        {
            if (hit.collider.CompareTag("Target"))
            {
                _object = hit.collider.gameObject;
                crosshair.color = new Color(1.0f, 1.0f, 1.0f, 0.40f);
            }



        }
        else
        {
            crosshair.color = new Color(1.0f, 1.0f, 1.0f, 0.75f);
        }


    }


}
