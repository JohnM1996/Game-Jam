using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Computer : MonoBehaviour 
{
	public GameObject ourDoor;
     public Light CeilingLight;
	 public GameObject CatPoster;
	 public GameObject Necronomicon;
	 public GameObject Radio;

	 public AudioClip Jazz;
	 public AudioClip Buzzing;
	 public AudioClip Whispers;
	 public AudioClip click;


	 public Canvas ComputerScreen;
     public string QuestionText = "";
	 public Text Question;
	 public string[] AllQuestions;

	 public int RandEvent = 0;
	// Use this for initialization
	// Use this for initialization
	void Start () 
	{
		RandEvent = Random.Range(0,AllQuestions.Length);
		QuestionText = AllQuestions[RandEvent];
		Question.text = QuestionText;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	 public void NoAnswer(int num)
	{
		num  = RandEvent;
		RoomSpawning rSpawn = gameObject.GetComponent<RoomSpawning>();
       switch (num)
      {
		  case 0:
              rSpawn.SpawnRoom();
              
              break;
          case 1:
              rSpawn.SpawnRoom();
              
              break;
          case 2:
             rSpawn.SpawnRoom();

              break;
		  case 3:
             rSpawn.SpawnRoom();

              break;
		  case 4:
             rSpawn.SpawnRoom();

              break;
          default:
             rSpawn.SpawnRoom();

              break;			  
      }
	  AnswerSelected();
	}
	public void YesAnswer(int num)
	{
	num  = RandEvent;
		RoomSpawning rSpawn = gameObject.GetComponent<RoomSpawning>();
      switch (num)
      {
		  case 0:
              rSpawn.SpawnRoom();
              
              break;
          case 1:
              rSpawn.SpawnRoom();
              
              break;
          case 2:
             rSpawn.SpawnRoom();

              break;
		  case 3:
             rSpawn.SpawnRoom();

              break;
		  case 4:
             rSpawn.SpawnRoom();

              break;
          default:
             rSpawn.SpawnRoom();

              break;			  
      }
	  AnswerSelected();
	}

	public void AnswerSelected()
	{
		ComputerScreen.enabled = false;
		ourDoor.GetComponent<Door>().isLocked = false;
	}
}
