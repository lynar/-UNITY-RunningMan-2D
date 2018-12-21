using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ninja : MonoBehaviour {

    public bool isDead = false;
    private Rigidbody2D colEnn; //pour gérer la collision avec l'ennemi
    private Rigidbody2D colSol; //pour gérer la collision avec le sol
	private Animator anim; 

    public float upForce = 50f; //correspond à la force du saut. +cette valeur est grande, plus le ninja sautera haut

	// Use this for initialization
	void Start () {
        colSol = GetComponent<Rigidbody2D>(); //initialise la collision
        colEnn = GetComponent<Rigidbody2D>(); //initialise la collision
		anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
        if(isDead == false)
        {         
            //pour que le ninja garde la même abscisse
            Vector3 position = transform.position;
            position[0] = -4; // the Z value
            transform.position = position;

            colSol.freezeRotation = true;
                

                    if (Input.GetMouseButtonDown(0) && position[1] <= 1f)
                    {
                        colSol.velocity = Vector2.zero; //utile dans le cas du flappy bird, mais pas dans le nôtre
                        colSol.AddForce(new Vector2(0, upForce));
                        anim.SetTrigger("Flap");

                    }
        }
	}
		
}
