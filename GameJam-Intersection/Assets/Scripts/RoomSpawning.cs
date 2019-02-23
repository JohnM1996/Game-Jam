using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawning : MonoBehaviour 
{
	public GameObject RoomToSpawn;
    public Vector3 offset;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider collision)
	{
		if(collision.gameObject.tag == "Player")
		{
         SpawnRoom();
		}
	}

	public void SpawnRoom()
	{
     Instantiate(RoomToSpawn, transform.position + offset, transform.rotation);
	}
}
