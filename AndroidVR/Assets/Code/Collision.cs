using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {

    Rigidbody player;
    Rigidbody enemy;
    Rigidbody Barrier;

	// Use this for initialization
	void Start () {
        player = GetComponent<Rigidbody>();
        enemy = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision player)
    {
        if(player.gameObject.name == "barrier ")
        {
            
        }
    }
}
