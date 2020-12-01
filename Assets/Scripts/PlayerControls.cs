using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerControls : MonoBehaviour
{
    //input system
    private Input playerInput;
    [SerializeField] private GameScript _gameManager;

    //camera
    private Vector2 direction = Vector2.zero;
    private Vector2 zoom = Vector2.zero;
    private float zoom1 = 0.0f;
    private Vector2 moveVec = Vector2.zero;

    private float sensitivity = 30.0f;
    private float speed = 3.0f;
    private Vector2 rotation = Vector2.zero;

    private float fov;



    //shot
    private List<Color> _colours;
    private int _currentColour = 0;
    private int _shot = -1;

    //raycast
    private GameObject _object;
    [SerializeField] private int _ray = 10;
    [SerializeField] private LayerMask _interactMask;

    [SerializeField] private Image _crosshair;
    [SerializeField] private Image _colourBar;


    void Awake()
    {
        playerInput = new Input();

        playerInput.Camera.Look.performed += ctx => direction = ctx.ReadValue<Vector2>();
        playerInput.Camera.Look.canceled += ctx => direction = Vector2.zero;

        playerInput.Camera.Zoom.performed += ctx => zoom = ctx.ReadValue<Vector2>();
        playerInput.Camera.Zoom.canceled += ctx => zoom = Vector2.zero;

        playerInput.Camera.Zoom1.performed += ctx => zoom1 = 1.0f;
        playerInput.Camera.Zoom1.canceled += ctx => zoom1 = 0.0f;
        playerInput.Camera.Zoom2.performed += ctx => zoom1 = -1.0f;
        playerInput.Camera.Zoom2.canceled += ctx => zoom1 = 0.0f;

        playerInput.Gameplay.ShootSphere.performed += ctx => Shoot(0);
        playerInput.Gameplay.ShootCube.performed += ctx => Shoot(1);
        playerInput.Gameplay.SwitchWeaponLeft.performed += ctx => SwitchWeapon(0);
        playerInput.Gameplay.SwitchWeaponRight.performed += ctx => SwitchWeapon(1);

        playerInput.Gameplay.Move.performed += ctx => moveVec = ctx.ReadValue<Vector2>();
        playerInput.Gameplay.Move.canceled += ctx => moveVec = Vector2.zero;

        //other awake functions
        _colours = new List<Color> { Color.red, Color.blue, Color.green, new Color (1, 1, 0)};
        fov = GetComponent<Camera>().fieldOfView;
    }

    private void Update()
    {
        Camera();
        Raycast();
    }

    private void Camera()
    {
        Cursor.lockState = CursorLockMode.Locked;

        transform.position += new Vector3(moveVec.x, 0, moveVec.y);

        rotation.y += direction.x * Time.deltaTime;
        //rotation.y = Mathf.Clamp(rotation.y, 0.0f, 25.0f);
        rotation.x -= direction.y * Time.deltaTime;
        transform.eulerAngles = rotation * speed;

        if (zoom.y < 0)
        {
            fov -= 3.0f;
        }
        else if (zoom.y > 0)
        {
            fov += 3.0f;
        }

        if (zoom1 > 0)
        {
            fov -= 0.5f;
        }
        else if (zoom1 < 0)
        {
            fov += 0.5f;
        }

        fov = Mathf.Clamp(fov, 5.0f, 60.0f);
        GetComponent<Camera>().fieldOfView = fov;
    }

    private void Raycast()
    {
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, forward, out hit, _ray, _interactMask.value))
        {
            if (hit.collider.CompareTag("Target"))
            {
                _object = hit.collider.gameObject;
                _crosshair.color = new Color(1.0f, 1.0f, 1.0f, 0.40f);

                if (_shot == _object.GetComponent<Target>().shape &&
                    _colours[_currentColour] ==
                    _object.gameObject.GetComponent<Renderer>().material.color)
                {
                    _gameManager.SendHit(_object);
                }

            }
        }
        else
        {
            _crosshair.color = new Color(1.0f, 1.0f, 1.0f, 0.75f);
        }

        _shot = -1;
    }

    private void Shoot(int type)
    {
        _shot = type; 
    }

    private void SwitchWeapon(int dir)
    {
        if (dir == 1)
        {
            if (_currentColour == _colours.Count - 1)
            {
                _currentColour = 0;
            }
            else
            { 
                _currentColour += 1;
            }
        }
        else
        {
            if (_currentColour == 0)
            {
                _currentColour = _colours.Count - 1;
            }
            else
            {
                _currentColour -= 1;
            }
        }
        _colourBar.color = _colours[_currentColour];
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
