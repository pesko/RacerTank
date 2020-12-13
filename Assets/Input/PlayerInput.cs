// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Tank"",
            ""id"": ""766038bf-8295-43ed-9a59-befa238b5925"",
            ""actions"": [
                {
                    ""name"": ""Drive"",
                    ""type"": ""Value"",
                    ""id"": ""aba00835-eeec-4a91-b457-d85eabe4e454"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""931247a8-1d10-4623-867c-d0e516d2361e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Turret"",
                    ""type"": ""Value"",
                    ""id"": ""11948e18-27f1-4382-a69b-f74806c2841e"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""35df39de-0a27-497b-9403-bc00c1e484ed"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""1d6bfaa8-a206-4d49-bbd8-4ad3df3cb1e2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9ee87b91-7833-4111-a997-d0d418e05c6e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""603418b1-dcdd-4153-95cb-68723e711810"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""aebc237a-aaed-4c84-a258-7fc4e34f208a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6de6285d-a089-4846-93c9-8fd5d99e8936"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c29c186b-3d2e-410a-8a4c-410635c30d85"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b603250-7639-4390-a4e6-5fa85105a126"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""171fb06a-f605-4045-a178-4843ed8d1f1e"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""3c4ec671-b4c9-438f-aa26-449d17bcdcae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1a41fa39-2efa-411f-9ff8-007154cee1dd"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TankControls"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""TankControls"",
            ""bindingGroup"": ""TankControls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Tank
        m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
        m_Tank_Drive = m_Tank.FindAction("Drive", throwIfNotFound: true);
        m_Tank_Shoot = m_Tank.FindAction("Shoot", throwIfNotFound: true);
        m_Tank_Turret = m_Tank.FindAction("Turret", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

    // Tank
    private readonly InputActionMap m_Tank;
    private ITankActions m_TankActionsCallbackInterface;
    private readonly InputAction m_Tank_Drive;
    private readonly InputAction m_Tank_Shoot;
    private readonly InputAction m_Tank_Turret;
    public struct TankActions
    {
        private @PlayerInput m_Wrapper;
        public TankActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drive => m_Wrapper.m_Tank_Drive;
        public InputAction @Shoot => m_Wrapper.m_Tank_Shoot;
        public InputAction @Turret => m_Wrapper.m_Tank_Turret;
        public InputActionMap Get() { return m_Wrapper.m_Tank; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
        public void SetCallbacks(ITankActions instance)
        {
            if (m_Wrapper.m_TankActionsCallbackInterface != null)
            {
                @Drive.started -= m_Wrapper.m_TankActionsCallbackInterface.OnDrive;
                @Drive.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnDrive;
                @Drive.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnDrive;
                @Shoot.started -= m_Wrapper.m_TankActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnShoot;
                @Turret.started -= m_Wrapper.m_TankActionsCallbackInterface.OnTurret;
                @Turret.performed -= m_Wrapper.m_TankActionsCallbackInterface.OnTurret;
                @Turret.canceled -= m_Wrapper.m_TankActionsCallbackInterface.OnTurret;
            }
            m_Wrapper.m_TankActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Drive.started += instance.OnDrive;
                @Drive.performed += instance.OnDrive;
                @Drive.canceled += instance.OnDrive;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Turret.started += instance.OnTurret;
                @Turret.performed += instance.OnTurret;
                @Turret.canceled += instance.OnTurret;
            }
        }
    }
    public TankActions @Tank => new TankActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private @PlayerInput m_Wrapper;
        public UIActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_TankControlsSchemeIndex = -1;
    public InputControlScheme TankControlsScheme
    {
        get
        {
            if (m_TankControlsSchemeIndex == -1) m_TankControlsSchemeIndex = asset.FindControlSchemeIndex("TankControls");
            return asset.controlSchemes[m_TankControlsSchemeIndex];
        }
    }
    public interface ITankActions
    {
        void OnDrive(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTurret(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
