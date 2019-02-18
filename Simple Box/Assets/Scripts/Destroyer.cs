using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Destroyer : MonoBehaviour {

    //private CameraShake shake;



	// Use this for initialization
	void Start () {
        //shake = GetComponent<CameraShake>();
        //shake = GameObject.FindGameObjectsWithTag("ScreenShake");
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        Destroy(other.gameObject);
       // shake.CamShake();
        Destroy(gameObject);
    }
}
