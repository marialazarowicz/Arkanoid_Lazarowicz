using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Transform paddle;
    public bool inPlay = false;
    [SerializeField] float pushUp = 9f;
    [SerializeField] float pushRight = 2f;

    void Update()
    {
        if(!inPlay)
        {
            transform.position = paddle.position;
            LaunchOnSpace();
        }
        
    }

    private void LaunchOnSpace()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            inPlay = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(pushRight, pushUp);
            }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bottom"))
        {
            inPlay = false;
        }
    }
}
