using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensivityX=8f;
    [SerializeField] float sensivityY=0.5f;
    float MouseX, mouseY;
    [SerializeField] Transform playerCamera;
    [SerializeField] float xClamp=55f;
    float xRotation= 0f;
    void Update()
    {
        transform.Rotate(Vector3.up, MouseX * Time.deltaTime);

        xRotation-=mouseY;
        xRotation=Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x =xRotation;
        playerCamera.eulerAngles=targetRotation;
    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        MouseX= mouseInput.x * sensivityX;
        mouseY= mouseInput.y * sensivityY;
    }
}
