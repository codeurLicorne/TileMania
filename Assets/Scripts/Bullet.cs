using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletSpeed = 20f;
    Rigidbody2D myRigibody;
    Player player;
    float xSpeed;

    void Start()
    {
        myRigibody = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<Player>();
        xSpeed = player.transform.localScale.x * bulletSpeed;
    }

   
    void Update()
    {
        myRigibody.velocity = new Vector2(xSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }

   void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
