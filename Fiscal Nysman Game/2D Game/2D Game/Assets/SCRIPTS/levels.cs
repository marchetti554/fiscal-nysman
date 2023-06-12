using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class levels : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void cargarNivel()
    {
        
        Time.timeScale = 1; 
        SceneManager.LoadScene("Escena1");
        Time.timeScale = 1;

    }
}
