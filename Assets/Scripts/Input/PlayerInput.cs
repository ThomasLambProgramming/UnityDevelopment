// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input/PlayerInput.inputactions'

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
            ""name"": ""Player"",
            ""id"": ""5630d233-91ad-46fe-a274-277851e97a0f"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""c6f4738f-9b38-47b7-a4ea-efd82799ae41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""2bbb2811-4541-4fc9-9d4a-0d68f23499cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""Button"",
                    ""id"": ""8b6a4c9a-23d6-41dd-b6df-254550f90185"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""45b1b33c-0346-4bf0-bc1a-fb793608169b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mouse"",
                    ""type"": ""Value"",
                    ""id"": ""88beb7bc-b8c3-46b7-af9d-a07c7f2246d1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""9c426a1c-d2a0-46ea-9fb1-d2f89708651b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha1"",
                    ""type"": ""Button"",
                    ""id"": ""fab5887a-6b2a-4bc9-bf56-eec2fe369687"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha2"",
                    ""type"": ""Button"",
                    ""id"": ""26cea4da-f63a-41d4-8df5-ae0d69189368"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha3"",
                    ""type"": ""Button"",
                    ""id"": ""5cfcdaec-db6b-4993-8ace-d113bab11952"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha4"",
                    ""type"": ""Button"",
                    ""id"": ""31394994-a9f2-4fb8-b388-4b185ac21487"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha5"",
                    ""type"": ""Button"",
                    ""id"": ""18724f35-bb9c-4423-ab52-a2b49bd790ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha6"",
                    ""type"": ""Button"",
                    ""id"": ""c7bc70df-094c-46cd-9358-c110b641e74e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha7"",
                    ""type"": ""Button"",
                    ""id"": ""0d517c77-fad3-401a-aac6-e6e2a58d7ebe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha8"",
                    ""type"": ""Button"",
                    ""id"": ""8cc6b668-236b-453d-84c9-05e392010522"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha9"",
                    ""type"": ""Button"",
                    ""id"": ""85ff6f41-7d61-4129-bdf7-8fab7ef190b4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Alpha0"",
                    ""type"": ""Button"",
                    ""id"": ""236b2e8e-a6ab-4660-9790-1a2f3eb9eb6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""0cd0e997-841c-43de-abad-282aa8404f85"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8bb810dd-65fe-449c-9299-72a8b5d0da60"",
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
                    ""id"": ""b49a0086-1d55-46b1-bafc-e7c884372c11"",
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
                    ""id"": ""9e9999d4-bdf7-465c-99dc-d30c615843ba"",
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
                    ""id"": ""958d607a-f5bd-4283-81cc-cfc979253b5e"",
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
                    ""id"": ""f67c9608-e57e-46df-b3ed-dede8ec34cac"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5c47a03a-34b7-493b-b605-67d58a8c8309"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1b0c92b-6e91-4051-a107-1e329596a2f8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2182ffd2-2601-4525-9407-58c1fe89ed5b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da12c799-0e72-4001-bc80-c087cda0d4a4"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Mouse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22ef0974-779b-45a8-9147-37c52de4374a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdb14a31-97c4-4828-b03d-8a8039371ebe"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e833026-2603-4a4d-b1d1-1aca43eeddc0"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a667e22a-c4f2-47c1-b1ee-beba5384fafe"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c1d9965-acae-49a6-a395-02c761f769c7"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2af964b-d1d0-4b78-ae6e-0c4fba23c73f"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a816f1a9-8a88-4718-8ddb-6b8dca800496"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9b4387d-5e6b-432e-9d74-577351270601"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha7"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79551440-c3ad-4de0-a607-1922bf5e32cf"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha8"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18409b64-e0fa-42bd-a95a-5d9c54dadef9"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha9"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26a06bbf-6fbb-4aba-90c8-d70d61f9211a"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Alpha0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d292318e-9510-486c-af52-6480b8a23423"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_LeftClick = m_Player.FindAction("LeftClick", throwIfNotFound: true);
        m_Player_RightClick = m_Player.FindAction("RightClick", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Mouse = m_Player.FindAction("Mouse", throwIfNotFound: true);
        m_Player_Escape = m_Player.FindAction("Escape", throwIfNotFound: true);
        m_Player_Alpha1 = m_Player.FindAction("Alpha1", throwIfNotFound: true);
        m_Player_Alpha2 = m_Player.FindAction("Alpha2", throwIfNotFound: true);
        m_Player_Alpha3 = m_Player.FindAction("Alpha3", throwIfNotFound: true);
        m_Player_Alpha4 = m_Player.FindAction("Alpha4", throwIfNotFound: true);
        m_Player_Alpha5 = m_Player.FindAction("Alpha5", throwIfNotFound: true);
        m_Player_Alpha6 = m_Player.FindAction("Alpha6", throwIfNotFound: true);
        m_Player_Alpha7 = m_Player.FindAction("Alpha7", throwIfNotFound: true);
        m_Player_Alpha8 = m_Player.FindAction("Alpha8", throwIfNotFound: true);
        m_Player_Alpha9 = m_Player.FindAction("Alpha9", throwIfNotFound: true);
        m_Player_Alpha0 = m_Player.FindAction("Alpha0", throwIfNotFound: true);
        m_Player_MousePosition = m_Player.FindAction("MousePosition", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_LeftClick;
    private readonly InputAction m_Player_RightClick;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Mouse;
    private readonly InputAction m_Player_Escape;
    private readonly InputAction m_Player_Alpha1;
    private readonly InputAction m_Player_Alpha2;
    private readonly InputAction m_Player_Alpha3;
    private readonly InputAction m_Player_Alpha4;
    private readonly InputAction m_Player_Alpha5;
    private readonly InputAction m_Player_Alpha6;
    private readonly InputAction m_Player_Alpha7;
    private readonly InputAction m_Player_Alpha8;
    private readonly InputAction m_Player_Alpha9;
    private readonly InputAction m_Player_Alpha0;
    private readonly InputAction m_Player_MousePosition;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @LeftClick => m_Wrapper.m_Player_LeftClick;
        public InputAction @RightClick => m_Wrapper.m_Player_RightClick;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Mouse => m_Wrapper.m_Player_Mouse;
        public InputAction @Escape => m_Wrapper.m_Player_Escape;
        public InputAction @Alpha1 => m_Wrapper.m_Player_Alpha1;
        public InputAction @Alpha2 => m_Wrapper.m_Player_Alpha2;
        public InputAction @Alpha3 => m_Wrapper.m_Player_Alpha3;
        public InputAction @Alpha4 => m_Wrapper.m_Player_Alpha4;
        public InputAction @Alpha5 => m_Wrapper.m_Player_Alpha5;
        public InputAction @Alpha6 => m_Wrapper.m_Player_Alpha6;
        public InputAction @Alpha7 => m_Wrapper.m_Player_Alpha7;
        public InputAction @Alpha8 => m_Wrapper.m_Player_Alpha8;
        public InputAction @Alpha9 => m_Wrapper.m_Player_Alpha9;
        public InputAction @Alpha0 => m_Wrapper.m_Player_Alpha0;
        public InputAction @MousePosition => m_Wrapper.m_Player_MousePosition;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @LeftClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @LeftClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftClick;
                @RightClick.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightClick;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Mouse.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @Mouse.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @Mouse.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMouse;
                @Escape.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEscape;
                @Alpha1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha1;
                @Alpha1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha1;
                @Alpha1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha1;
                @Alpha2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha2;
                @Alpha2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha2;
                @Alpha2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha2;
                @Alpha3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha3;
                @Alpha3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha3;
                @Alpha3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha3;
                @Alpha4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha4;
                @Alpha4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha4;
                @Alpha4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha4;
                @Alpha5.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha5;
                @Alpha5.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha5;
                @Alpha5.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha5;
                @Alpha6.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha6;
                @Alpha6.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha6;
                @Alpha6.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha6;
                @Alpha7.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha7;
                @Alpha7.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha7;
                @Alpha7.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha7;
                @Alpha8.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha8;
                @Alpha8.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha8;
                @Alpha8.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha8;
                @Alpha9.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha9;
                @Alpha9.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha9;
                @Alpha9.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha9;
                @Alpha0.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha0;
                @Alpha0.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha0;
                @Alpha0.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAlpha0;
                @MousePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePosition;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @LeftClick.started += instance.OnLeftClick;
                @LeftClick.performed += instance.OnLeftClick;
                @LeftClick.canceled += instance.OnLeftClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Mouse.started += instance.OnMouse;
                @Mouse.performed += instance.OnMouse;
                @Mouse.canceled += instance.OnMouse;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @Alpha1.started += instance.OnAlpha1;
                @Alpha1.performed += instance.OnAlpha1;
                @Alpha1.canceled += instance.OnAlpha1;
                @Alpha2.started += instance.OnAlpha2;
                @Alpha2.performed += instance.OnAlpha2;
                @Alpha2.canceled += instance.OnAlpha2;
                @Alpha3.started += instance.OnAlpha3;
                @Alpha3.performed += instance.OnAlpha3;
                @Alpha3.canceled += instance.OnAlpha3;
                @Alpha4.started += instance.OnAlpha4;
                @Alpha4.performed += instance.OnAlpha4;
                @Alpha4.canceled += instance.OnAlpha4;
                @Alpha5.started += instance.OnAlpha5;
                @Alpha5.performed += instance.OnAlpha5;
                @Alpha5.canceled += instance.OnAlpha5;
                @Alpha6.started += instance.OnAlpha6;
                @Alpha6.performed += instance.OnAlpha6;
                @Alpha6.canceled += instance.OnAlpha6;
                @Alpha7.started += instance.OnAlpha7;
                @Alpha7.performed += instance.OnAlpha7;
                @Alpha7.canceled += instance.OnAlpha7;
                @Alpha8.started += instance.OnAlpha8;
                @Alpha8.performed += instance.OnAlpha8;
                @Alpha8.canceled += instance.OnAlpha8;
                @Alpha9.started += instance.OnAlpha9;
                @Alpha9.performed += instance.OnAlpha9;
                @Alpha9.canceled += instance.OnAlpha9;
                @Alpha0.started += instance.OnAlpha0;
                @Alpha0.performed += instance.OnAlpha0;
                @Alpha0.canceled += instance.OnAlpha0;
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLeftClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMouse(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnAlpha1(InputAction.CallbackContext context);
        void OnAlpha2(InputAction.CallbackContext context);
        void OnAlpha3(InputAction.CallbackContext context);
        void OnAlpha4(InputAction.CallbackContext context);
        void OnAlpha5(InputAction.CallbackContext context);
        void OnAlpha6(InputAction.CallbackContext context);
        void OnAlpha7(InputAction.CallbackContext context);
        void OnAlpha8(InputAction.CallbackContext context);
        void OnAlpha9(InputAction.CallbackContext context);
        void OnAlpha0(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
    }
}
