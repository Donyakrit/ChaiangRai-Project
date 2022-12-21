//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputAction/PlayerInputAction.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""Portal"",
            ""id"": ""220a9e25-54d7-47b8-8071-694a42656e0f"",
            ""actions"": [
                {
                    ""name"": ""TP"",
                    ""type"": ""Button"",
                    ""id"": ""adef8953-e19f-4049-9a0a-09aef82c99d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7bc9f002-4658-4060-a4d1-ea6c13218ad4"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Onfoot"",
            ""id"": ""a01493c2-3f58-4bcb-b96e-fa849bd3ee8f"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""7c311248-6746-4f9f-9137-fdad104263e6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7ab7dfa7-e757-44cd-9bc9-25b46b3b1ce5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""07d8d351-4bed-40f5-9935-5b9b3d310c33"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""de93e6ac-1ba8-4527-b0ea-aa258642ff55"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eff8ac40-fd30-4917-9b77-f6a032a461f8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8c35585f-e43a-4107-804b-19bb1a070b93"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8cfe3160-06f9-4673-97c3-78ad15b9c3b0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftStick"",
                    ""id"": ""fab8123e-0ec4-4621-a77c-da0ac676fb82"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4f0ef4f4-ad7a-4fca-9bce-4e9319ca61f0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0ba68d59-584e-4aab-96fb-1f0fb1811421"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""126a6c35-1256-4a9f-abad-fc35a3150efb"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a406787f-71f3-4d20-a0e1-4aae81a83794"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""314e529c-8db6-43bd-a9a0-c73081446eb9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2cb49133-6437-4009-86a6-26176d57e878"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Pause"",
            ""id"": ""0453de2c-88f8-4ce6-87aa-19d1e2deee4d"",
            ""actions"": [
                {
                    ""name"": ""Pausethegame"",
                    ""type"": ""Button"",
                    ""id"": ""0e68d00b-3195-41a1-8b8d-454814fce307"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f95f693-8999-46b8-a97e-573930c1fd5b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pausethegame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Portal
        m_Portal = asset.FindActionMap("Portal", throwIfNotFound: true);
        m_Portal_TP = m_Portal.FindAction("TP", throwIfNotFound: true);
        // Onfoot
        m_Onfoot = asset.FindActionMap("Onfoot", throwIfNotFound: true);
        m_Onfoot_Movement = m_Onfoot.FindAction("Movement", throwIfNotFound: true);
        m_Onfoot_Jump = m_Onfoot.FindAction("Jump", throwIfNotFound: true);
        // Pause
        m_Pause = asset.FindActionMap("Pause", throwIfNotFound: true);
        m_Pause_Pausethegame = m_Pause.FindAction("Pausethegame", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Portal
    private readonly InputActionMap m_Portal;
    private IPortalActions m_PortalActionsCallbackInterface;
    private readonly InputAction m_Portal_TP;
    public struct PortalActions
    {
        private @PlayerInputAction m_Wrapper;
        public PortalActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @TP => m_Wrapper.m_Portal_TP;
        public InputActionMap Get() { return m_Wrapper.m_Portal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PortalActions set) { return set.Get(); }
        public void SetCallbacks(IPortalActions instance)
        {
            if (m_Wrapper.m_PortalActionsCallbackInterface != null)
            {
                @TP.started -= m_Wrapper.m_PortalActionsCallbackInterface.OnTP;
                @TP.performed -= m_Wrapper.m_PortalActionsCallbackInterface.OnTP;
                @TP.canceled -= m_Wrapper.m_PortalActionsCallbackInterface.OnTP;
            }
            m_Wrapper.m_PortalActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TP.started += instance.OnTP;
                @TP.performed += instance.OnTP;
                @TP.canceled += instance.OnTP;
            }
        }
    }
    public PortalActions @Portal => new PortalActions(this);

    // Onfoot
    private readonly InputActionMap m_Onfoot;
    private IOnfootActions m_OnfootActionsCallbackInterface;
    private readonly InputAction m_Onfoot_Movement;
    private readonly InputAction m_Onfoot_Jump;
    public struct OnfootActions
    {
        private @PlayerInputAction m_Wrapper;
        public OnfootActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Onfoot_Movement;
        public InputAction @Jump => m_Wrapper.m_Onfoot_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Onfoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnfootActions set) { return set.Get(); }
        public void SetCallbacks(IOnfootActions instance)
        {
            if (m_Wrapper.m_OnfootActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_OnfootActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_OnfootActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_OnfootActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_OnfootActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_OnfootActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_OnfootActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_OnfootActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public OnfootActions @Onfoot => new OnfootActions(this);

    // Pause
    private readonly InputActionMap m_Pause;
    private IPauseActions m_PauseActionsCallbackInterface;
    private readonly InputAction m_Pause_Pausethegame;
    public struct PauseActions
    {
        private @PlayerInputAction m_Wrapper;
        public PauseActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pausethegame => m_Wrapper.m_Pause_Pausethegame;
        public InputActionMap Get() { return m_Wrapper.m_Pause; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseActions set) { return set.Get(); }
        public void SetCallbacks(IPauseActions instance)
        {
            if (m_Wrapper.m_PauseActionsCallbackInterface != null)
            {
                @Pausethegame.started -= m_Wrapper.m_PauseActionsCallbackInterface.OnPausethegame;
                @Pausethegame.performed -= m_Wrapper.m_PauseActionsCallbackInterface.OnPausethegame;
                @Pausethegame.canceled -= m_Wrapper.m_PauseActionsCallbackInterface.OnPausethegame;
            }
            m_Wrapper.m_PauseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pausethegame.started += instance.OnPausethegame;
                @Pausethegame.performed += instance.OnPausethegame;
                @Pausethegame.canceled += instance.OnPausethegame;
            }
        }
    }
    public PauseActions @Pause => new PauseActions(this);
    public interface IPortalActions
    {
        void OnTP(InputAction.CallbackContext context);
    }
    public interface IOnfootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPauseActions
    {
        void OnPausethegame(InputAction.CallbackContext context);
    }
}
