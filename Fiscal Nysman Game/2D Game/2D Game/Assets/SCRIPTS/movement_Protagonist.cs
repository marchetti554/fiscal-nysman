using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement_Protagonist : MonoBehaviour {

    public float velocidad;
    float direccion;
    public int jump_number = 0;
    public float fuerza_salto = 0;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        direccion = Input.GetAxis("Horizontal");

        GetComponent<Animator>().SetFloat("velocity", Mathf.Abs(direccion));

        GetComponent<Rigidbody2D>().AddForce(Vector2.right * direccion * velocidad);
        GetComponent<Rigidbody2D>().velocity = new Vector2(direccion * velocidad, GetComponent<Rigidbody2D>().velocity.y);

        if (direccion < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (direccion > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetBool("isRunning", true);
        } else GetComponent<Animator>().SetBool("isRunning", false);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerza_salto, ForceMode2D.Impulse);
            GetComponent<Animator>().SetTrigger("jump");

        }
             
	}


 }


