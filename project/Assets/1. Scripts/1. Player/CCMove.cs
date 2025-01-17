using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCMove : MonoBehaviour
{
    Animator anim;
    CharacterController CC;
    float speed;
    Vector3 sumVec, xVec, yVec, zVec;
    float yAxis = 0;
    float r;
    float rotateSpeed = 100;
    float gravity = 3.8f;

    void Awake()
    {
        CC = GetComponent<CharacterController>();
        speed = PlayerStats.basePlayerSpeed;
    }
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        xVec = transform.right * x * Time.deltaTime;

        if (CC.isGrounded == false)
        {
            yAxis -= gravity * Time.deltaTime;
        }

        yVec = new Vector3(0, yAxis, 0);
        zVec = transform.forward * z * Time.deltaTime;

        sumVec = xVec + yVec + zVec;

        CC.Move(sumVec);
        r = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, r, 0); 
        anim.SetBool("IsRun", Mathf.Abs(x) > 0 || Mathf.Abs(z) > 0);
    }
    
}
