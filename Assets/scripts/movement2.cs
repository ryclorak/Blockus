using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    Rigidbody rb;
    Transform tf;
    public float speed;
    public float jumpHeight = 5f;
    public bool isGrounded;
    public float numJumps = 0f;
    public float maxJumps = 2;
    float rotateSpeed = 10f;
    public float horiz;
    public float verti;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tf = GetComponent<Transform>();
        speed = 10;
    }

    void Update()
    {
        verti = Input.GetAxisRaw("Vertical");
        horiz = Input.GetAxisRaw("Horizontal");
        tf.Translate(Vector3.forward * Time.deltaTime * speed * verti);
        tf.Rotate(Vector3.right * Time.deltaTime * rotateSpeed * horiz);
    }
}
