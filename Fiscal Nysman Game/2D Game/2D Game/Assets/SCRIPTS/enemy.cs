using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public float velocidad;
    public float direccion;
	// Use this for initialization
	void Update () 
    {
        GetComponent<Animator>().SetFloat("veloc", Mathf.Abs(direccion));


        Vector3 movimiento = new Vector3 (direccion * Time.deltaTime * velocidad, 0, 0);
        transform.Translate(movimiento);

        if (direccion < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            if (direccion > 0)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "turnArea")
        {
            direccion = -direccion; 
        }
    }


}
