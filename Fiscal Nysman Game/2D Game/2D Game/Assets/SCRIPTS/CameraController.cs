﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject Personaje;
    private Vector3 offset; 

	// Use this for initialization
	void Start () 
    {
        offset = transform.position - Personaje.transform.position; 		
	}
	
	// Update is called once per frame
	void LateUpdate () 
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        transform.position = Personaje.transform.position + offset;
		
	}
}
