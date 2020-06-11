using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExample : MonoBehaviour {

	public GameObject cat;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
			
	}


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("WallTag"))
        {
            ReverseCat();
        }
    }

    void ReverseCat()
    {
        var currentSpeed = cat.GetComponent<movement>().speed;
        cat.gameObject.transform.RotateAround(transform.position, transform.up, 180f);
        if (currentSpeed <= 15)
        {
            var sp = currentSpeed * 1.3;

            currentSpeed = Convert.ToInt32(sp);
        }

        else
        {
            currentSpeed = 10;
        }
        cat.GetComponent<movement>().speed = currentSpeed * -1;
    }
}