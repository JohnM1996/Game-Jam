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
        RaycastHit hit;

        if (Vector3.Distance(transform.position, Player.transform.position) < 1.5f)
        {


            if (Physics.Raycast(Player.transform.position, Player.transform.TransformDirection(Vector3.forward), out hit, 5f))
            {
<<<<<<< HEAD
                myRB.AddForceAtPosition((Player.transform.forward * 50f * (myRB.mass)), hit.point);
            }
            //myRB.velocity = myRB.velocity + (hit.point * 3);


=======
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Did Hit");
            }
            //myRB.velocity = myRB.velocity + (hit.point * 3);

            myRB.AddForceAtPosition((Player.transform.forward * 50f * (myRB.mass)), hit.point);
>>>>>>> master
        }
	}
}
