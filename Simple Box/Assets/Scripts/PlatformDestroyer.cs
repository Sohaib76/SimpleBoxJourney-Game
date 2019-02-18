using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Camera.main.transform.position) > 10)
            Destroy(gameObject);

       

    }
}
