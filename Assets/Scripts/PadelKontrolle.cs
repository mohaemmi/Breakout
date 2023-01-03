using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelKontrolle : MonoBehaviour
{

    Rigidbody body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
          body.MovePosition(body .position + Vector3.left * Time.deltaTime * 1);
        if (Input.GetKey(KeyCode.RightArrow))
          body.MovePosition(body .position + Vector3.right * Time.deltaTime * 1);
        
    }
}
