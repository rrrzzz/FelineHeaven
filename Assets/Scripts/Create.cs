using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create : MonoBehaviour {

    public GameObject [] enemy;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var pos = GameObject.Find("FPSController").transform.position;
            var num = Random.Range(0, 4);
            Instantiate(enemy[num], pos, Quaternion.identity);
        }
    }
}
