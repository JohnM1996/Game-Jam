using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabbable : MonoBehaviour 
{
	public bool isHeld = false;
     Rigidbody myRB;
	// Use this for initialization
	void Start () 
	{
		myRB = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnMouseDown()
	{
		GameObject Player = GameObject.FindGameObjectWithTag("Player");
		 myRB.velocity = myRB.velocity + (Player.transform.forward * 3);		
	}
}
