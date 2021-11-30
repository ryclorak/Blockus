using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horiz = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");

        rb.AddForce(horiz * speed, 0, verti * speed);



    }
    
    void Update()
    {


    }

}
