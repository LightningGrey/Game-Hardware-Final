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


    //UI manager
    [Header("UI")]
    [SerializeField] private UIManager _manager;
    [SerializeField] private Image mouseBase;
    [SerializeField] private Image mouseScroll;
    [SerializeField] private Image mouseLeft;
    [SerializeField] private Image mouseRight;
    [SerializeField] private Image mouseSideTop;
    [SerializeField] private Image mouseSideBottom;

    [SerializeField] private Image pedalUp;
    [SerializeField] private Image pedalDown;
    [SerializeField] private Image pedalLeft;
    [SerializeField] private Image pedalRight;

    [SerializeField] private Image joystickUp;
    [SerializeField] private Image joystickDown;
    [SerializeField] private Image joystickLeft;
    [SerializeField] private Image joystickRight;
    [SerializeField] private Image joystickZoom;
    [SerializeField] private Image joystickShoot1;
    [SerializeField] private Image joystickShoot2;
    [SerializeField] private Image joystickMode;

    float baseTime;
    float scrollTime;
    float leftTime;
    float rightTime;
    float topTime;
    float bottomTime;
    bool _baseTime;
    bool _scrollTime;
    bool _leftTime;
    bool _rightTime;
    bool _topTime;
    bool _bottomTime;

    float p_upTime;
    float p_shoot2Time;
    float p_leftTime;
    float p_rightTime;
    bool _p_upTime;
    bool _p_shoot2Time;
    bool _p_leftTime;
    bool _p_rightTime;

    float j_upTime;
    float j_downTime;
    float j_leftTime;
    float j_rightTime;
    float j_zoomTime;
    float j_shoot1Time;
    float j_shoot2Time;
    float j_modeTime;
    bool _j_upTime;
    bool _j_downTime;
    bool _j_leftTime;
    bool _j_rightTime;
    bool _j_zoomTime;
    bool _j_shoot1Time;
    bool _j_shoot2Time;
    bool _j_modeTime;


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

        playerInput.Gameplay.Swap.performed += ctx => Swap();

        //other awake functions
        _colours = new List<Color> { Color.red, Color.blue, Color.green, new Color (1, 1, 0)};
        fov = GetComponent<Camera>().fieldOfView;
    }

    private void Update()
    {
        Camera();
        Raycast();
        Timer();
    }

    private void Camera()
    {
        Cursor.lockState = CursorLockMode.Locked;

        transform.position += new Vector3(moveVec.x, 0, moveVec.y);

        if (moveVec.x > 0)
        {
            _manager.ColourOn(pedalRight);
            _p_rightTime = true;
        }

        if (moveVec.x < 0)
        {
            _manager.ColourOn(pedalLeft);
            _p_leftTime = true;
        }

        if (moveVec.y > 0)
        {
            _manager.ColourOn(pedalUp);
            _p_upTime = true;
        }

        if (moveVec.y < 0)
        {
            _manager.ColourOn(pedalDown);
            _p_shoot2Time = true;
        }

        rotation.y += direction.x * Time.deltaTime;
        //rotation.y = Mathf.Clamp(rotation.y, 0.0f, 25.0f);
        rotation.x -= direction.y * Time.deltaTime;
        transform.eulerAngles = rotation * speed;

        if (direction != Vector2.zero)
        {
            _manager.ColourOn(mouseBase);
            _baseTime = true;
        }

        if (direction.x > 0)
        {
            _manager.ColourOn(joystickRight);
            _j_rightTime = true;
        }

        if (direction.x < 0)
        {
            _manager.ColourOn(joystickLeft);
            _j_leftTime = true;
        }

        if (direction.y > 0)
        {
            _manager.ColourOn(joystickUp);
            _j_upTime = true;
        }

        if (direction.y < 0)
        {
            _manager.ColourOn(joystickDown);
            _j_downTime = true;
        }

        if (zoom.y > 0)
        {
            fov -= 3.0f;
            _manager.ColourOn(mouseScroll);
            _scrollTime = true;
        }
        else if (zoom.y < 0)
        {
            fov += 3.0f;
            _manager.ColourOn(mouseScroll);
            _scrollTime = true;
        } 

        if (zoom1 > 0)
        {
            fov -= 0.5f;
            _manager.ColourOn(joystickZoom);
            _j_zoomTime = true; 
        }
        else if (zoom1 < 0)
        {
            fov += 0.5f;
            _manager.ColourOn(joystickZoom);
            _j_zoomTime = true;
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
        if (type == 0)
        {
            _manager.ColourOn(mouseLeft);
            _manager.ColourOn(joystickShoot1);
            _leftTime = true;
            _j_shoot1Time = true;
        } else
        {
            _manager.ColourOn(mouseRight);
            _manager.ColourOn(joystickShoot2);
            _rightTime = true;
            _j_shoot2Time = true;
        }
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
            _manager.ColourOn(mouseSideTop);
            _topTime = true;
            _manager.ColourOn(joystickMode);
            _j_modeTime = true;
            
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
            _manager.ColourOn(mouseSideBottom);
            _bottomTime = true;
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


    private void Timer()
    {
        if (_baseTime == true && direction == Vector2.zero)
        {
            baseTime += Time.deltaTime;
            if (baseTime >= 0.5f)
            {
                _manager.ColourOff(mouseBase);
                baseTime = 0.0f;
                _baseTime = false;
            }

        }
        if (_scrollTime == true && zoom == Vector2.zero)
        {
            scrollTime += Time.deltaTime;
            if (scrollTime >= 0.5f)
            {
                _manager.ColourOff(mouseScroll);
                scrollTime = 0.0f;
                _scrollTime = false;
            }

        }

        if (_leftTime == true)
        {
            leftTime += Time.deltaTime;
            if (leftTime >= 0.5f)
            {
                _manager.ColourOff(mouseLeft);
                leftTime = 0.0f;
                _leftTime = false;
            }

        }

        if (_rightTime == true)
        {
            rightTime += Time.deltaTime;
            if (rightTime >= 0.5f)
            {
                _manager.ColourOff(mouseRight);
                rightTime = 0.0f;
                _rightTime = false;
            }

        }

        if (_topTime == true)
        {
            topTime += Time.deltaTime;
            if (topTime >= 0.5f)
            {
                _manager.ColourOff(mouseSideTop);
                topTime = 0.0f;
                _topTime = false;
            }

        }

        if (_bottomTime == true)
        {
            bottomTime += Time.deltaTime;
            if (bottomTime >= 0.5f)
            {
                _manager.ColourOff(mouseSideBottom);
                bottomTime = 0.0f;
                _bottomTime = false;
            }

        }

        if (_bottomTime == true)
        {
            bottomTime += Time.deltaTime;
            if (bottomTime >= 0.5f)
            {
                _manager.ColourOff(mouseSideBottom);
                bottomTime = 0.0f;
                _bottomTime = false;
            }

        }


        if (_p_upTime == true && moveVec.y == 0.0f)
        {
            p_upTime += Time.deltaTime;
            if (p_upTime >= 0.5f)
            {
                _manager.ColourOff(pedalUp);
                p_upTime = 0.0f;
                _p_upTime = false;
            }

        }

        if (_p_shoot2Time == true && moveVec.y == 0.0f)
        {
            p_shoot2Time += Time.deltaTime;
            if (p_shoot2Time >= 0.5f)
            {
                _manager.ColourOff(pedalDown);
                p_shoot2Time = 0.0f;
                _p_shoot2Time = false;
            }

        }

        if (_p_leftTime == true && moveVec.x == 0.0f)
        {
            p_leftTime += Time.deltaTime;
            if (p_leftTime >= 0.5f)
            {
                _manager.ColourOff(pedalLeft);
                p_leftTime = 0.0f;
                _p_leftTime = false;
            }

        }

        if (_p_rightTime == true && moveVec.x == 0.0f)
        {
            p_rightTime += Time.deltaTime;
            if (p_rightTime >= 0.5f)
            {
                _manager.ColourOff(pedalRight);
                p_rightTime = 0.0f;
                _p_rightTime = false;
            }

        }


        if (_j_leftTime == true && direction.x == 0.0f)
        {
            j_leftTime += Time.deltaTime;
            if (j_leftTime >= 0.5f)
            {
                _manager.ColourOff(joystickLeft);
                j_leftTime = 0.0f;
                _j_leftTime = false;
            }

        }

        if (_j_rightTime == true && direction.x == 0.0f)
        {
            j_rightTime += Time.deltaTime;
            if (j_rightTime >= 0.5f)
            {
                _manager.ColourOff(joystickRight);
                j_rightTime = 0.0f;
                _j_rightTime = false;
            }

        }

        if (_j_upTime == true && direction.x == 0.0f)
        {
            j_upTime += Time.deltaTime;
            if (j_upTime >= 0.5f)
            {
                _manager.ColourOff(joystickUp);
                j_upTime = 0.0f;
                _j_upTime = false;
            }

        }

        if (_j_downTime == true && direction.x == 0.0f)
        {
            j_downTime += Time.deltaTime;
            if (j_downTime >= 0.5f)
            {
                _manager.ColourOff(joystickDown);
                j_downTime = 0.0f;
                _j_downTime = false;
            }

        }

        if (_j_zoomTime == true)
        {
            j_zoomTime += Time.deltaTime;
            if (j_zoomTime >= 0.5f)
            {
                _manager.ColourOff(joystickZoom);
                j_zoomTime = 0.0f;
                _j_zoomTime = false;
            }

        }

        if (_j_shoot1Time == true)
        {
            j_shoot1Time += Time.deltaTime;
            if (j_shoot1Time >= 0.5f)
            {
                _manager.ColourOff(joystickShoot1);
                j_shoot1Time = 0.0f;
                _j_shoot1Time = false;
            }

        }

        if (_j_shoot2Time == true)
        {
            j_shoot2Time += Time.deltaTime;
            if (j_shoot2Time >= 0.5f)
            {
                _manager.ColourOff(joystickShoot2);
                j_shoot2Time = 0.0f;
                _j_shoot2Time = false;
            }

        }

        if (_j_modeTime == true)
        {
            j_modeTime += Time.deltaTime;
            if (j_modeTime >= 0.5f)
            {
                _manager.ColourOff(joystickMode);
                j_modeTime = 0.0f;
                _j_modeTime = false;
            }

        }
    }

    public void Swap()
    {
        mouseBase.gameObject.SetActive(!mouseBase.IsActive());
        mouseScroll.gameObject.SetActive(!mouseScroll.IsActive());
        mouseLeft.gameObject.SetActive(!mouseLeft.IsActive());
        mouseRight.gameObject.SetActive(!mouseRight.IsActive());
        mouseSideTop.gameObject.SetActive(!mouseSideTop.IsActive());
        mouseSideBottom.gameObject.SetActive(!mouseSideBottom.IsActive());

        joystickUp.gameObject.SetActive(!joystickUp.IsActive());
        joystickDown.gameObject.SetActive(!joystickDown.IsActive());
        joystickLeft.gameObject.SetActive(!joystickLeft.IsActive());
        joystickRight.gameObject.SetActive(!joystickRight.IsActive());
        joystickZoom.gameObject.SetActive(!joystickZoom.IsActive());
        joystickShoot1.gameObject.SetActive(!joystickShoot1.IsActive());
        joystickShoot2.gameObject.SetActive(!joystickShoot2.IsActive());
        joystickMode.gameObject.SetActive(!joystickMode.IsActive());
    }
}
