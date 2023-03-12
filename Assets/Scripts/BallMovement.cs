using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;

    private GameObject padel;
    private Vector3 offset;
    private Rigidbody2D body;
    private bool startPosition = true;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        padel = GameObject.Find("Padel");
        offset = new Vector3(0, transform.localScale.y * 0.5f + padel.transform.localScale.y * 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && startPosition)
        {
            body.AddForce(Vector2.up * speed);
            startPosition = false;
        }

        if (startPosition)
        {
            transform.position = padel.transform.position + offset;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collison)
    {
        FindObjectOfType<GameManager>().GameOver();   
    }
}
