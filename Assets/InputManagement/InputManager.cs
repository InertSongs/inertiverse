// GENERATED AUTOMATICALLY FROM 'Assets/InputManagement/InputManager.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputManager : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputManager"",
    ""maps"": [
        {
            ""name"": ""ManualTurn"",
            ""id"": ""7dd88e24-835b-4b99-9039-db845e2a501f"",
            ""actions"": [
                {
                    ""name"": ""Show Move Range"",
                    ""type"": ""Button"",
                    ""id"": ""6e3e509a-5ce7-4402-a003-9772acce0587"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""5525b752-093e-449d-a3a0-88d2534c0d2e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""97bd1c0f-655d-49d8-8c51-7705159da0ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Ability"",
                    ""type"": ""Button"",
                    ""id"": ""b28b0766-358f-4aaf-8bd8-771f118b45d6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pass"",
                    ""type"": ""Button"",
                    ""id"": ""b870050b-f402-46c9-be8c-5c22162b205e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuNav"",
                    ""type"": ""Value"",
                    ""id"": ""bf51aa87-6149-439d-a6e3-87379f2d3692"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a6a0f920-8dc3-4089-aa8a-75de7030a211"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Show Move Range"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e668a32a-ebdd-48de-9b72-9909db913dcd"",
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
                    ""id"": ""15acb1be-0ddc-407c-a008-3a4c9a87884f"",
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
                    ""id"": ""0f752f8e-c5b2-48d2-8840-6acb30526fa1"",
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
                    ""id"": ""abeb253b-40ae-4577-a0c3-3371998c0913"",
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
                    ""id"": ""e242ebec-f294-48bf-9ecf-8e178a316cb5"",
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
                    ""id"": ""99d06312-3a50-414f-bec3-44bdf27e6a41"",
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
                    ""id"": ""984c794c-2b4a-41e0-8c86-f242236a856c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Ability"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cbbf44f-3f38-4584-84bf-d73ad605c4a3"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pass"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f3ddf300-859d-4d6f-83c2-63b2eaab46eb"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNav"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""647afb1b-2af3-444a-98d8-77b8e1e9973c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""f3a7e838-41e7-47f8-8709-9ae4345ca791"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuNav"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ManualTurn
        m_ManualTurn = asset.FindActionMap("ManualTurn", throwIfNotFound: true);
        m_ManualTurn_ShowMoveRange = m_ManualTurn.FindAction("Show Move Range", throwIfNotFound: true);
        m_ManualTurn_Movement = m_ManualTurn.FindAction("Movement", throwIfNotFound: true);
        m_ManualTurn_Interact = m_ManualTurn.FindAction("Interact", throwIfNotFound: true);
        m_ManualTurn_Ability = m_ManualTurn.FindAction("Ability", throwIfNotFound: true);
        m_ManualTurn_Pass = m_ManualTurn.FindAction("Pass", throwIfNotFound: true);
        m_ManualTurn_MenuNav = m_ManualTurn.FindAction("MenuNav", throwIfNotFound: true);
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

    // ManualTurn
    private readonly InputActionMap m_ManualTurn;
    private IManualTurnActions m_ManualTurnActionsCallbackInterface;
    private readonly InputAction m_ManualTurn_ShowMoveRange;
    private readonly InputAction m_ManualTurn_Movement;
    private readonly InputAction m_ManualTurn_Interact;
    private readonly InputAction m_ManualTurn_Ability;
    private readonly InputAction m_ManualTurn_Pass;
    private readonly InputAction m_ManualTurn_MenuNav;
    public struct ManualTurnActions
    {
        private @InputManager m_Wrapper;
        public ManualTurnActions(@InputManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @ShowMoveRange => m_Wrapper.m_ManualTurn_ShowMoveRange;
        public InputAction @Movement => m_Wrapper.m_ManualTurn_Movement;
        public InputAction @Interact => m_Wrapper.m_ManualTurn_Interact;
        public InputAction @Ability => m_Wrapper.m_ManualTurn_Ability;
        public InputAction @Pass => m_Wrapper.m_ManualTurn_Pass;
        public InputAction @MenuNav => m_Wrapper.m_ManualTurn_MenuNav;
        public InputActionMap Get() { return m_Wrapper.m_ManualTurn; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ManualTurnActions set) { return set.Get(); }
        public void SetCallbacks(IManualTurnActions instance)
        {
            if (m_Wrapper.m_ManualTurnActionsCallbackInterface != null)
            {
                @ShowMoveRange.started -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnShowMoveRange;
                @ShowMoveRange.performed -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnShowMoveRange;
                @ShowMoveRange.canceled -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnShowMoveRange;
                @Movement.started -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnInteract;
                @Ability.started -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnAbility;
                @Ability.performed -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnAbility;
                @Ability.canceled -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnAbility;
                @Pass.started -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnPass;
                @Pass.performed -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnPass;
                @Pass.canceled -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnPass;
                @MenuNav.started -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnMenuNav;
                @MenuNav.performed -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnMenuNav;
                @MenuNav.canceled -= m_Wrapper.m_ManualTurnActionsCallbackInterface.OnMenuNav;
            }
            m_Wrapper.m_ManualTurnActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ShowMoveRange.started += instance.OnShowMoveRange;
                @ShowMoveRange.performed += instance.OnShowMoveRange;
                @ShowMoveRange.canceled += instance.OnShowMoveRange;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Ability.started += instance.OnAbility;
                @Ability.performed += instance.OnAbility;
                @Ability.canceled += instance.OnAbility;
                @Pass.started += instance.OnPass;
                @Pass.performed += instance.OnPass;
                @Pass.canceled += instance.OnPass;
                @MenuNav.started += instance.OnMenuNav;
                @MenuNav.performed += instance.OnMenuNav;
                @MenuNav.canceled += instance.OnMenuNav;
            }
        }
    }
    public ManualTurnActions @ManualTurn => new ManualTurnActions(this);
    public interface IManualTurnActions
    {
        void OnShowMoveRange(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnAbility(InputAction.CallbackContext context);
        void OnPass(InputAction.CallbackContext context);
        void OnMenuNav(InputAction.CallbackContext context);
    }
}
