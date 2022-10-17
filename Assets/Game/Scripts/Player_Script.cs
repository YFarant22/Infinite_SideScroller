using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_Script : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 jumpForce;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jumpForce = new Vector2(0f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            jumpAction();
        }
    }

    void jumpAction() 
    {
        print("dectedted");
        rb.AddForce(jumpForce, ForceMode2D.Impulse);
    } 
}
