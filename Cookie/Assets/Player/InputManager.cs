using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;
    [SerializeField]Pick_Class picking;
    [SerializeField]Menu Menuing;
    PlayerControl controls;
    PlayerControl.GroundMovementActions groundMovement;
    Vector2 horizontalInput;
    Vector2 mouseInput;
    PlayerControl.PickActions pick;
    PlayerControl.MenuActions menu;
    
    

    private void Awake()
    {   
        controls= new PlayerControl();
        groundMovement = controls.GroundMovement;
        pick=controls.Pick;
        menu=controls.Menu;

        // groundMovement.[action].performed += context => faz alg cena
        groundMovement.HorizontalMovement.performed += ctx=> horizontalInput= ctx.ReadValue<Vector2>();

        groundMovement.Jump.performed+= _ => movement.OnJumpPressed();

        groundMovement.MouseX.performed+= ctx => mouseInput.x=ctx.ReadValue<float>();
        groundMovement.MouseY.performed+= ctx => mouseInput.y=ctx.ReadValue<float>();

        pick.Pick.performed+= __=> picking.picking();

        menu.Pause.performed+= _ =>Menuing.MenuPause();
    }

    void Update()
    {
        if (!Menu.Paused)
        {
            movement.ReceiveInput(horizontalInput);
            mouseLook.ReceiveInput(mouseInput);
        }
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDestroy()
    {
        controls.Disable();
    }

}
