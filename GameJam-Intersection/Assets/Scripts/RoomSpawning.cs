using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawning : MonoBehaviour 
{
	public GameObject Door;
	public GameObject RoomToSpawn;
    public Vector3 offset;
	public Vector3 door1Offset;

	public bool IsStartRoom = false;
	
	public GameObject T;
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


	public void SpawnRoom()
	{
     T = Instantiate(RoomToSpawn, transform.position + offset, Quaternion.identity);
	 
	 if(IsStartRoom)
	 {
		 T.GetComponentInChildren<RoomSpawning>().IsStartRoom = false;
	 }	 
	}
}
