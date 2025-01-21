using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform cameraTransform; 
    public float jumpForce = 5f;
    public Vector3 InputKey;
    public Rigidbody rb;
    public bool IsGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputKey = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            IsGrounded = false;
        }
        
    }
    void FixedUpdate()
    {
        // ????? ??? ???? ?? ???? ??? ??????
        Vector3 forward = cameraTransform.forward; // ??? ?????? ??????
        Vector3 right = cameraTransform.right;     // ??? ???? ??????
                                                   // ?????? ?? ?????? ???? (???? ??? ??? ???? x ? z)
        forward.y = 0f;
        right.y = 0f;

        // ?????????? ??????
        forward.Normalize();
        right.Normalize();
        // ???? ?? ???? ????? ? ??? ??????
        Vector3 desiredMoveDirection = (forward * InputKey.z + right * InputKey.x).normalized;

        rb.AddForce(desiredMoveDirection * 15f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bubble"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsGrounded = true;
        }
    }
}
