using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour {
    Rigidbody rb;
    public float speed;
    // private float boostTimer;
    // private bool boosting;

    void Start() {
        rb = GetComponent<Rigidbody>();
        speed = 10;
        // boostTimer = 0;
        // boosting = false;
    }

    void FixedUpdate() {
        float horiz = Input.GetAxisRaw("Horizontal");
        float verti = Input.GetAxisRaw("Vertical");

        rb.AddForce(horiz * speed, 0, verti * speed);

        // if (boosting) {
        //     boostTimer +=Time.deltaTime;
        //     if (boostTimer >= 3) {
        //         speed = 10;
        //         boostTimer = 0;
        //         boosting = false;
        //     }
        // }
    }
    
    void Update()
    {
        if (rb.position.y < -1) {
            SceneManager.LoadScene("SampleScene");
        }
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.tag == "triangle1m") {
            rb.AddForce(0, 0, speed * 15);
            Debug.Log("triangled");
            rb.velocity *= 2;
        }
    }

    // void OnTriggerEnter(Collider col) { //if passing through an object
    //     if (col.tag == "triangle1m") {
    //         boosting = true;
    //         speed = 50;
    //         Debug.Log("Boosting");
    //     }
    // }

}
