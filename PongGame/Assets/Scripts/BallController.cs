using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class BallController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public int score1;
    public int score2;
    private LevelManager _levelManager;
    void Start()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(x*speed, y*speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(score1 == 5 || score2 == 5)
        {
            _levelManager.GameOver();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Kale1"))
        {
            score1++;
        }

        if(collision.gameObject.CompareTag("Kale2"))
        {
            score2++;
        }
    }
} //Top kalelere çarptığında puan ekle ve göster
