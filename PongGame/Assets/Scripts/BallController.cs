using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;


public class BallController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;

    public TextMeshProUGUI Win1;
    public TextMeshProUGUI Win2;
    void Start()
    { 
        Win1 = GameObject.Find("Win1").GetComponent<TextMeshProUGUI>();
        Win2 = GameObject.Find("Win2").GetComponent<TextMeshProUGUI>();


        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x*speed, y*speed);

        Win1.gameObject.SetActive(false);
        Win2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag =="Kale1")
        {
            Win1.gameObject.SetActive(true);
            rb.velocity = Vector2.zero;
            speed = 0;
        }

        if(collision.gameObject.tag =="Kale2")
        {
            Win2.gameObject.SetActive(true);
            rb.velocity = Vector2.zero;
            speed = 0;
        }
    }
} 
