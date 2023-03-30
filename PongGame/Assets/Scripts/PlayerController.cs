using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isPlayer1;
    public Rigidbody2D rb;
    public float speed;
    
    void Update()
    {
        if(isPlayer1)
        {
            rb.velocity = Vector2.up*Input.GetAxisRaw("Vertical")*speed;
        }
        else
        {
            rb.velocity = Vector2.up*Input.GetAxisRaw("Vertical2")*speed;
        }
    }
}
