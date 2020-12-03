// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""Camera"",
            ""id"": ""ddab31f7-64fb-4490-b253-90937808a7eb"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e1612822-0d52-4749-a794-a798be8182e4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4f94e143-74d1-4a6e-a99f-2668be9f4d17"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom1"",
                    ""type"": ""Button"",
                    ""id"": ""c9a1ae77-0b4e-4649-aa17-df52147d563a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Scale(factor=0.05)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom2"",
                    ""type"": ""Button"",
                    ""id"": ""084fb625-a5a2-43fa-9e8c-ee66ddda0c7c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": ""Scale(factor=0.05)"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4572524b-dba1-47b3-8acc-1d1317b85c70"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3285e26c-6a00-4c62-a14b-8b3fc96dbc5c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=10,y=10)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2d1c6095-bc19-44dd-8f26-d78905a8a625"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""80e39852-96a1-4ec9-9efa-882002579991"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ba90fbdf-5445-4802-913e-1e390936be5d"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""49f157dd-afdb-4e14-952c-9c490e04309f"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bf5cbc8c-5dea-447a-88f6-767d7c221fdd"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d178b8c1-22f1-4b50-9d26-8f7bb9d86761"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Zoom1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3559927e-0503-4ce8-8790-eb5d4b992b68"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Zoom2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gameplay"",
            ""id"": ""b976f9f9-7e68-4a3e-ba13-38d8e8006409"",
            ""actions"": [
                {
                    ""name"": ""ShootSphere"",
                    ""type"": ""Button"",
                    ""id"": ""aca7bf8b-d703-406e-8cec-e7a7d3a6cf66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootCube"",
                    ""type"": ""Button"",
                    ""id"": ""f55bad50-7cad-41ae-9988-b1255f9fc58f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchWeaponLeft"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1d890031-5cba-4c82-b455-3dabb9ca4beb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SwitchWeaponRight"",
                    ""type"": ""Button"",
                    ""id"": ""1cc4d599-cdef-40d3-8667-bb2228f3ce9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""54f64ec9-4e78-445d-bf41-e9a97c93ccf4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""ScaleVector2(x=0.05,y=0.05)"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Swap"",
                    ""type"": ""Button"",
                    ""id"": ""f8a66944-1835-4644-bf7a-94f80c6c8b4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""361af2c3-291c-49c1-8e78-e6ed61156dea"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""ShootSphere"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b93ee95-967f-4054-bf6e-61eaa3cef5a8"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""ShootSphere"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b154881a-0534-47c7-bc39-37d2916d9728"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""ShootCube"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4be89d0a-70fd-4d4e-93b3-28646a7eb738"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""ShootCube"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95b61eae-a743-4baa-aba0-ae67d9e77151"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""SwitchWeaponLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""052faf61-dc61-4325-bad2-0a8414280e97"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""SwitchWeaponRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d0ccf62-d5ce-4a2b-ad10-5c37937171a7"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""SwitchWeaponRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2bcabbfb-aa92-4078-86e4-302159d2c56b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""39a56eb1-06d7-40e8-b005-83dd67ee542b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse;Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""62a39b1f-b6d1-4eca-b1ba-5b871c38322f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse;Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""13e946f4-28d7-408b-b55d-35045b475618"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse;Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aa81ddec-c687-45c8-8f60-a948748329c8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse;Joystick"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e4ca0983-433d-41ba-b98b-362d712277cd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse;Joystick"",
                    ""action"": ""Swap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Mouse"",
            ""bindingGroup"": ""Mouse"",
            ""devices"": []
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": []
        }
    ]
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Look = m_Camera.FindAction("Look", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        m_Camera_Zoom1 = m_Camera.FindAction("Zoom1", throwIfNotFound: true);
        m_Camera_Zoom2 = m_Camera.FindAction("Zoom2", throwIfNotFound: true);
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_ShootSphere = m_Gameplay.FindAction("ShootSphere", throwIfNotFound: true);
        m_Gameplay_ShootCube = m_Gameplay.FindAction("ShootCube", throwIfNotFound: true);
        m_Gameplay_SwitchWeaponLeft = m_Gameplay.FindAction("SwitchWeaponLeft", throwIfNotFound: true);
        m_Gameplay_SwitchWeaponRight = m_Gameplay.FindAction("SwitchWeaponRight", throwIfNotFound: true);
        m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
        m_Gameplay_Swap = m_Gameplay.FindAction("Swap", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_Look;
    private readonly InputAction m_Camera_Zoom;
    private readonly InputAction m_Camera_Zoom1;
    private readonly InputAction m_Camera_Zoom2;
    public struct CameraActions
    {
        private @Input m_Wrapper;
        public CameraActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Camera_Look;
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
        public InputAction @Zoom1 => m_Wrapper.m_Camera_Zoom1;
        public InputAction @Zoom2 => m_Wrapper.m_Camera_Zoom2;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnLook;
                @Zoom.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom;
                @Zoom1.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom1;
                @Zoom1.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom1;
                @Zoom1.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom1;
                @Zoom2.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom2;
                @Zoom2.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom2;
                @Zoom2.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnZoom2;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Zoom1.started += instance.OnZoom1;
                @Zoom1.performed += instance.OnZoom1;
                @Zoom1.canceled += instance.OnZoom1;
                @Zoom2.started += instance.OnZoom2;
                @Zoom2.performed += instance.OnZoom2;
                @Zoom2.canceled += instance.OnZoom2;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_ShootSphere;
    private readonly InputAction m_Gameplay_ShootCube;
    private readonly InputAction m_Gameplay_SwitchWeaponLeft;
    private readonly InputAction m_Gameplay_SwitchWeaponRight;
    private readonly InputAction m_Gameplay_Move;
    private readonly InputAction m_Gameplay_Swap;
    public struct GameplayActions
    {
        private @Input m_Wrapper;
        public GameplayActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShootSphere => m_Wrapper.m_Gameplay_ShootSphere;
        public InputAction @ShootCube => m_Wrapper.m_Gameplay_ShootCube;
        public InputAction @SwitchWeaponLeft => m_Wrapper.m_Gameplay_SwitchWeaponLeft;
        public InputAction @SwitchWeaponRight => m_Wrapper.m_Gameplay_SwitchWeaponRight;
        public InputAction @Move => m_Wrapper.m_Gameplay_Move;
        public InputAction @Swap => m_Wrapper.m_Gameplay_Swap;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @ShootSphere.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootSphere;
                @ShootSphere.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootSphere;
                @ShootSphere.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootSphere;
                @ShootCube.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootCube;
                @ShootCube.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootCube;
                @ShootCube.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShootCube;
                @SwitchWeaponLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchWeaponLeft;
                @SwitchWeaponLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchWeaponLeft;
                @SwitchWeaponLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchWeaponLeft;
                @SwitchWeaponRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchWeaponRight;
                @SwitchWeaponRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchWeaponRight;
                @SwitchWeaponRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwitchWeaponRight;
                @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @Swap.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwap;
                @Swap.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwap;
                @Swap.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnSwap;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShootSphere.started += instance.OnShootSphere;
                @ShootSphere.performed += instance.OnShootSphere;
                @ShootSphere.canceled += instance.OnShootSphere;
                @ShootCube.started += instance.OnShootCube;
                @ShootCube.performed += instance.OnShootCube;
                @ShootCube.canceled += instance.OnShootCube;
                @SwitchWeaponLeft.started += instance.OnSwitchWeaponLeft;
                @SwitchWeaponLeft.performed += instance.OnSwitchWeaponLeft;
                @SwitchWeaponLeft.canceled += instance.OnSwitchWeaponLeft;
                @SwitchWeaponRight.started += instance.OnSwitchWeaponRight;
                @SwitchWeaponRight.performed += instance.OnSwitchWeaponRight;
                @SwitchWeaponRight.canceled += instance.OnSwitchWeaponRight;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Swap.started += instance.OnSwap;
                @Swap.performed += instance.OnSwap;
                @Swap.canceled += instance.OnSwap;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    private int m_MouseSchemeIndex = -1;
    public InputControlScheme MouseScheme
    {
        get
        {
            if (m_MouseSchemeIndex == -1) m_MouseSchemeIndex = asset.FindControlSchemeIndex("Mouse");
            return asset.controlSchemes[m_MouseSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    public interface ICameraActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnZoom1(InputAction.CallbackContext context);
        void OnZoom2(InputAction.CallbackContext context);
    }
    public interface IGameplayActions
    {
        void OnShootSphere(InputAction.CallbackContext context);
        void OnShootCube(InputAction.CallbackContext context);
        void OnSwitchWeaponLeft(InputAction.CallbackContext context);
        void OnSwitchWeaponRight(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnSwap(InputAction.CallbackContext context);
    }
}
