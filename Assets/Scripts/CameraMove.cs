using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    Input playerInput;
    Vector2 direction = Vector2.zero;
    Vector2 zoom = Vector2.zero;

    float sensitivity = 30.0f;
    float speed = 3.0f;
    Vector2 rotation = Vector2.zero;

    float fov;

    // Start is called before the first frame update
    void Awake()
    {
        playerInput = new Input();

        playerInput.Camera.Look.performed += ctx => direction = ctx.ReadValue<Vector2>();
        playerInput.Camera.Look.canceled += ctx => direction = Vector2.zero;
                    
        playerInput.Camera.Zoom.performed += ctx => zoom = ctx.ReadValue<Vector2>();

        fov = GetComponent<Camera>().fieldOfView;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;

        rotation.y += direction.x * Time.deltaTime;
        //rotation.y = Mathf.Clamp(rotation.y, 0.0f, 25.0f);
        rotation.x -= direction.y * Time.deltaTime;
        transform.eulerAngles = rotation * speed;

        Debug.Log(zoom.y);
        if (zoom.y < 0)
        {
            fov -= 3.0f;
        }
        else if (zoom.y > 0)
        {
            fov += 3.0f;
        }

        fov = Mathf.Clamp(fov, 5.0f, 60.0f);
        GetComponent<Camera>().fieldOfView = fov;
       
    }


    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
}
