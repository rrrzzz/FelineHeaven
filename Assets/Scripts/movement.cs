using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    
    public float speed;

    //public GameObject ball;


    // Use this for initialization
    void Start()
    {
        speed = 7;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.forward * speed * Time.deltaTime;

    }
}