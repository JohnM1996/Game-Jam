using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	// Use this for initialization
	public bool isLocked = true;
	void Start () 
	{
		gameObject.GetComponent<Animator>().speed = 0f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

void OnMouseDown()
{
   if(!isLocked)
 {
	gameObject.GetComponent<Animator>().speed = 1f;

            if (gameObject.GetComponents<BoxCollider>()[1] != null)
            {
                Destroy(gameObject.GetComponents<BoxCollider>()[1]);
            }
	
 }
}
	
	void OnTriggerEnter(Collider collision)
	{
		if(collision.gameObject.tag == "Player")
		{
         isLocked = true;
		 Instantiate(gameObject,transform.position,transform.rotation);
		 Destroy(gameObject);
		}
		 
	}
}
