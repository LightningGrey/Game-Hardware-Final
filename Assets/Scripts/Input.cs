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
            ""id"": ""b2b0c7ff-16fd-49f8-82cb-97b0d774c996"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""6ac3f9f8-6e4f-4d86-b7d6-a8337c0ebac7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""400a4746-db04-480f-b8d0-4ace92687034"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0dab8d48-c938-4906-903f-ffaca23e14cf"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae5c08e6-893d-4e8a-8090-024e72669da2"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gameplay"",
            ""id"": ""d952b7b2-376e-4b3f-8791-40e179794680"",
            ""actions"": [
                {
                    ""name"": ""ShootSphere"",
                    ""type"": ""Button"",
                    ""id"": ""e5e20a3c-7e98-4184-9f00-83e6ca5d2129"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShootCube"",
                    ""type"": ""Button"",
                    ""id"": ""028a8c69-0529-42b4-9bed-873a400b6b43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchWeaponLeft"",
                    ""type"": ""Button"",
                    ""id"": ""101112a1-5420-47a7-90ad-15bc18a2edb7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchWeaponRight"",
                    ""type"": ""Button"",
                    ""id"": ""ff94bfde-ef00-4069-95f8-04e2fa81f9ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83abeec6-6e17-4101-832b-9ce420f3284e"",
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
                    ""id"": ""3789ed14-c78d-4fe1-8faf-b0f1cb05d788"",
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
                    ""id"": ""eaea58e9-d8a9-4445-926e-ce4387f698d1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""SwitchWeaponLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4237935-02ae-4729-9399-65985a1c4dfe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse"",
                    ""action"": ""SwitchWeaponRight"",
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
        }
    ]
}");
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_Look = m_Camera.FindAction("Look", throwIfNotFound: true);
        m_Camera_Zoom = m_Camera.FindAction("Zoom", throwIfNotFound: true);
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_ShootSphere = m_Gameplay.FindAction("ShootSphere", throwIfNotFound: true);
        m_Gameplay_ShootCube = m_Gameplay.FindAction("ShootCube", throwIfNotFound: true);
        m_Gameplay_SwitchWeaponLeft = m_Gameplay.FindAction("SwitchWeaponLeft", throwIfNotFound: true);
        m_Gameplay_SwitchWeaponRight = m_Gameplay.FindAction("SwitchWeaponRight", throwIfNotFound: true);
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
    public struct CameraActions
    {
        private @Input m_Wrapper;
        public CameraActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_Camera_Look;
        public InputAction @Zoom => m_Wrapper.m_Camera_Zoom;
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
    public struct GameplayActions
    {
        private @Input m_Wrapper;
        public GameplayActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShootSphere => m_Wrapper.m_Gameplay_ShootSphere;
        public InputAction @ShootCube => m_Wrapper.m_Gameplay_ShootCube;
        public InputAction @SwitchWeaponLeft => m_Wrapper.m_Gameplay_SwitchWeaponLeft;
        public InputAction @SwitchWeaponRight => m_Wrapper.m_Gameplay_SwitchWeaponRight;
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
    public interface ICameraActions
    {
        void OnLook(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
    }
    public interface IGameplayActions
    {
        void OnShootSphere(InputAction.CallbackContext context);
        void OnShootCube(InputAction.CallbackContext context);
        void OnSwitchWeaponLeft(InputAction.CallbackContext context);
        void OnSwitchWeaponRight(InputAction.CallbackContext context);
    }
}
