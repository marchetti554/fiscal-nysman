using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaProtagonista : MonoBehaviour {
    
    public GameObject panel;    
    public bool panelactivo = false; 
    public int vida = 100; 

	// Update is called once per frame
	void Update () 
    {
        if (vida == 0)
        {
            panelactivo = !panelactivo;
            
            panel.SetActive(true);            
        }
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "enemyKuka")
        {
            vida = 0;
            Time.timeScale = 0;
        }

    }

    public int getVida()
    {
        return vida; 
    }
}
