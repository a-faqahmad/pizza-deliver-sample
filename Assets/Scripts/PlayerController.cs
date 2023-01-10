using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 7.0f;
    float turnTime = 0.1f;
    float turnVelocity = 1f;
    private Animator anim;
    
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        Vector3 move = new Vector3(horizontal, 0, vertical);
        if(move.magnitude > 0) {
            anim.SetBool("isRunning", true);
            float newAngle = Mathf.Atan2(move.x, move.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, newAngle, ref turnVelocity, turnTime);
            transform.position += (move * playerSpeed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
        else
            anim.SetBool("isRunning", false);
    }
}
