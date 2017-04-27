using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeBehaviour : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void Start () {
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, 0, speed * Time.deltaTime);

        if(transform.position.z > 8)
        {
            speed = speed + .5f;
            transform.Translate(0, 0, -15);
        }
	}
}
