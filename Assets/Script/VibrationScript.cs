using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision collision)
	{
        if(collision.gameObject.tag == "wall"){
            
            if(SystemInfo.supportsVibration){
                Handheld.Vibrate();  
            }else{
                Debug.Log("Not Vibrate!");
            }

        }
	}
}
