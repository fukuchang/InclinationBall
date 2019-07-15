using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorInclinationScript : MonoBehaviour {
    

    private float speed = 500f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        var dir = Vector3.zero;

        dir.x = Input.acceleration.x;
        dir.z = Input.acceleration.y;

        dir *= Time.deltaTime;

        //if (-1.0f < dir.x * speed && dir.x * speed < 1.0f)
        //{
        //    dir.x = 0f;
        //}
        //if (-1.0f < dir.z * speed && dir.z * speed < 1.0f)
        //{
        //    dir.x = 0f;
        //}

        Debug.Log(dir);

        transform.eulerAngles = new Vector3(dir.z * speed, 0f, -dir.x * speed);

	}
}
