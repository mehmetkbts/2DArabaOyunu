using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject way;
    bool yol_yapildi = false;

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "mainCar" && yol_yapildi == false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawn_location, Quaternion.identity);
            yol_yapildi = true;
            ScoreManager.skor += 10;
            Destroy(this.gameObject, 6f);

        }
    }
}



