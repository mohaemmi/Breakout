using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PadelKontrolle : MonoBehaviour
{

    PadelPhysic body;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<PadelPhysic> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow))
          body.MovePosition (body .position + Vector3.left * 5);
        if (Input.GetKey(KeyCode.RightArrow))
          body.MovePosition (body .position + Vector3.right * 5);
    }
}
