// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Land"",
            ""id"": ""ab46ed25-4274-4c78-956b-cf9de97c19b4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f1669a60-b0aa-4b99-b743-3753dbe8a810"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""653b1209-8e44-46de-859b-5d0996597d18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3c258ede-98db-4033-b8c7-04881f34e046"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""554be45a-0132-436e-aa7c-060c8c348b8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""UpDown"",
                    ""type"": ""PassThrough"",
                    ""id"": ""36da4f3f-9184-413e-9e64-d8605c47a682"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""a174b9ff-71bf-4bb1-91bb-1de22e240ac4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6511c7ef-650b-4d12-8257-4b887db1ced0"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8ef28738-4bac-4087-9c84-072a41080be6"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f2d08ce6-eb56-407a-a753-85bcb923c094"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""28247790-406d-4e10-922e-7cfb98c77aae"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""029c748d-b5f1-4fff-891b-e74e5eb8d5c6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""98be1df5-c7bf-4004-8cca-6eb744534e71"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fc9be1e4-98bb-4328-9ef1-d0aa2061919e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7cacd9f3-5fdf-4694-9f3c-67725a3dae21"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3cc35080-7ff2-46db-b6b1-35429127980e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdd7d4b5-8f14-46c4-a3fe-877bbbec7b15"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a6fa21d8-e81b-4461-9691-3d8f1ae755bf"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e6df16aa-88d9-4808-b152-dcfb3ac37841"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""19040d95-65bc-4efe-9e18-36ca7ac1592b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b13132ab-bd80-4a04-9519-7ec1af65d719"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""08154bd7-cc39-473c-a82f-fc2a0f250e8b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""7400666f-45b7-4c2e-aec0-ed770fecb300"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e05686ab-9663-4088-87fa-182b0bfb9787"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UpDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Land
        m_Land = asset.FindActionMap("Land", throwIfNotFound: true);
        m_Land_Move = m_Land.FindAction("Move", throwIfNotFound: true);
        m_Land_Jump = m_Land.FindAction("Jump", throwIfNotFound: true);
        m_Land_Dash = m_Land.FindAction("Dash", throwIfNotFound: true);
        m_Land_LeftRight = m_Land.FindAction("LeftRight", throwIfNotFound: true);
        m_Land_UpDown = m_Land.FindAction("UpDown", throwIfNotFound: true);
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

    // Land
    private readonly InputActionMap m_Land;
    private ILandActions m_LandActionsCallbackInterface;
    private readonly InputAction m_Land_Move;
    private readonly InputAction m_Land_Jump;
    private readonly InputAction m_Land_Dash;
    private readonly InputAction m_Land_LeftRight;
    private readonly InputAction m_Land_UpDown;
    public struct LandActions
    {
        private @PlayerControlMap m_Wrapper;
        public LandActions(@PlayerControlMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Land_Move;
        public InputAction @Jump => m_Wrapper.m_Land_Jump;
        public InputAction @Dash => m_Wrapper.m_Land_Dash;
        public InputAction @LeftRight => m_Wrapper.m_Land_LeftRight;
        public InputAction @UpDown => m_Wrapper.m_Land_UpDown;
        public InputActionMap Get() { return m_Wrapper.m_Land; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LandActions set) { return set.Get(); }
        public void SetCallbacks(ILandActions instance)
        {
            if (m_Wrapper.m_LandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_LandActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnDash;
                @LeftRight.started -= m_Wrapper.m_LandActionsCallbackInterface.OnLeftRight;
                @LeftRight.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnLeftRight;
                @LeftRight.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnLeftRight;
                @UpDown.started -= m_Wrapper.m_LandActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_LandActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_LandActionsCallbackInterface.OnUpDown;
            }
            m_Wrapper.m_LandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @LeftRight.started += instance.OnLeftRight;
                @LeftRight.performed += instance.OnLeftRight;
                @LeftRight.canceled += instance.OnLeftRight;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
            }
        }
    }
    public LandActions @Land => new LandActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface ILandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnLeftRight(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
    }
}
