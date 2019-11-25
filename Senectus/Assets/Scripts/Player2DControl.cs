using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2DControl : MonoBehaviour
{
    public float speed = 7f;
    private Rigidbody2D rb;
    Animator anim;
    float vertical;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate() {
        vertical = Input.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.Translate(Vector2.right * -speed * Time.deltaTime);
            anim.SetBool("walk_l", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("walk_l", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.Translate(Vector2.right * speed * Time.deltaTime);
            anim.SetBool("walk_r", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("walk_r", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.Translate(Vector2.up * -speed * Time.deltaTime);
            anim.SetBool("walk_d", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("walk_d", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.Translate(Vector2.up * speed * Time.deltaTime);
            anim.SetBool("walk_u", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("walk_u", false);
        }
    }
}