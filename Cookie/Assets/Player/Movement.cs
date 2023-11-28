using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Animator animator;
    [SerializeField] CharacterController controller;
    [SerializeField] float speed=11f;
    Vector2 horizontalInput;

    [SerializeField] float jumpHeight=1.5f;
    bool jump;
    [SerializeField] float gravity=-30f;
    Vector3 verticalVelocity=Vector3.zero;
    [SerializeField] LayerMask groundMask;
    bool isGrounded;
    void Start() 
    {
        animator= GetComponent<Animator>();
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if (isGrounded)
        {
            verticalVelocity.y=0;
        }
        Vector3 horizontalVelocity =(transform.right*horizontalInput.x+transform.forward*horizontalInput.y)* speed;
        controller.Move(horizontalVelocity*Time.deltaTime);
        animator.SetFloat("velocidade",horizontalVelocity.magnitude);
        if (jump)
        {
            if (isGrounded)
            {
                
                verticalVelocity.y= Mathf.Sqrt(-2f*jumpHeight*gravity);
            }
            jump=false;
        }
        verticalVelocity.y+=gravity*Time.deltaTime;
        controller.Move(verticalVelocity*Time.deltaTime);
    }
    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput=_horizontalInput;
    }
    public void OnJumpPressed()
    {
        jump=true;
    }
}
