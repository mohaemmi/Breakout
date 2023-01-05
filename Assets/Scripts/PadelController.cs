using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelController : MonoBehaviour
{
    public float speed;
    private float border = 8;
     
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 move = Vector2.right * Time.deltaTime * horizontalInput * speed;

        if (transform.position.x + move.x > -border + transform.localScale.x * 0.5 && transform.position.x + move.x < border - transform.localScale.x * 0.5)
        {
            transform.Translate(move);
        }

        //if(transform.position.x < -8)
        //{
        //    transform.position = new Vector2(-8, transform.position.y);
        //}

        //if (transform.position.x > 8)
        //{
        //    transform.position = new Vector2(8, transform.position.y);
        //}



    }
}
