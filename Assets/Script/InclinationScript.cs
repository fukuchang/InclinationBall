using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclinationScript : MonoBehaviour {

    [SerializeField]
    private float speed = 0.1f;

    public Rigidbody rb;
    Vector3 vec;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        var dir = Vector3.zero;
        var pre_dir = dir;

        dir.x = Input.acceleration.x;
        dir.z = Input.acceleration.y;


        vec.x = dir.x + pre_dir.x;
        vec.z = dir.z + pre_dir.z;

        if(vec.sqrMagnitude > 1){
            vec.Normalize();
        }

        dir *= Time.deltaTime;
        transform.Translate(vec);
        //Debug.Log("x:" + dir.x + ", z:" + dir.z);
        //rb.AddForce(dir.x * speed, 0, dir.z * speed);

        pre_dir = dir;
	}
}
