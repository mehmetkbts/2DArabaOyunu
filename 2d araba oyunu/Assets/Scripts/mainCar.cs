using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCar : MonoBehaviour
{
    public float dikey_hiz, yatay_hiz, varsayilan_hiz;
    private float dikey_hareket, yatay_hareket;

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        dikey_hareket = Input.GetAxis("Vertical");
        yatay_hareket = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector3
       (yatay_hareket * 50 * yatay_hiz * Time.deltaTime, varsayilan_hiz + dikey_hareket * 50 * dikey_hiz * Time.deltaTime);

        if (transform.position.x > 1.85f)
        {
            Vector3 right_limit = new Vector3(1.85f, transform.position.y, transform.position.z);
            transform.position = right_limit;
        }

        if (transform.position.x < -1.82f)
        {
            Vector3 left_limit = new Vector3(-1.82f, transform.position.y, transform.position.z);
            transform.position = left_limit;
        }
    }
}




