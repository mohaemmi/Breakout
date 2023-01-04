using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelController : MonoBehaviour
{
    public float speed;
     
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltatime * horizontalInput * speed);

        if(transform.position.x < -8)
        {
            transform.position = new Vector2(-8, transform.position.y)
        }

        if (transform.position.x > 8)
        {
            transform.position = new Vector2(8, transform.position.y)
        }



    }
}
