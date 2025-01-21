using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PklayerCamera : MonoBehaviour
{
    public Transform Body;
    public Transform Head;

    public float MouseX;
    public float MouseY;

    public float Angle;
    public float MouseMoveSpeed = 300f;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MouseX = Input.GetAxis("Mouse X") * MouseMoveSpeed * Time.deltaTime;
        Body.Rotate(Vector3.up, MouseX);
        MouseY = Input.GetAxis("Mouse Y") * MouseMoveSpeed * Time.deltaTime;
        Angle -= MouseY;
        Angle = Mathf.Clamp(Angle, -30, 45);
        Head.localRotation = Quaternion.Euler(Angle, 0, 0);
    }
}
