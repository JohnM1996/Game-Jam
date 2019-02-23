using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleanup : MonoBehaviour 
{
    public GameObject Player;
	// Use this for initialization
	void Start () 
	{
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Vector3.Distance(transform.position, Player.transform.position) >= 15)
		{
			Destroy(gameObject);
		}
	}
}
