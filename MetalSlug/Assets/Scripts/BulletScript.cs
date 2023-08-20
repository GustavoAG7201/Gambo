using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public AudioClip Sound;
    public float speed;

    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        John john = collision.GetComponent<John>();
        GruntScript grunt = collision.GetComponent<GruntScript>();
        if (john != null)
        {
            john.Hit();
        }
        if (grunt != null)
        {
            grunt.Hit();
        }
        DestroyBullet();
    }

   















    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        John john = collision.GetComponent<John>();
        GruntScript grunt = collision.GetComponent<GruntScript>();

        if (john != null)
        {
            john.Hit();
        }
        if (grunt != null)
        {
            grunt.Hit();
        }

        DestroyBullet();
    
    }
    */
}
