using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawning : MonoBehaviour 
{
	public GameObject RoomToSpawn;
    public Vector3 offset;
	public bool IsStartRoom = false;
	
	// Use this for initialization
	void Start () 
	{
		if(IsStartRoom) 
		{
			SpawnRoom();
		}
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
     GameObject T = Instantiate(RoomToSpawn, transform.position + offset, transform.rotation);
	 if(IsStartRoom)
	 {
		 T.GetComponentInChildren<RoomSpawning>().IsStartRoom = false;
	 }
	 Destroy(gameObject);
	}
}
