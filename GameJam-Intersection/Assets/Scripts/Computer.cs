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
	 public GameObject Plant;
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
		gameObject.GetComponent<AudioSource>().PlayOneShot(click);
		num  = RandEvent;
		RoomSpawning rSpawn = gameObject.GetComponent<RoomSpawning>();
		rSpawn.SpawnRoom();
		rSpawn.T.GetComponentsInChildren<AudioSource>()[1].Stop();
       switch (num)
      {
		  case 0:
              
              rSpawn.T.GetComponentsInChildren<Light>()[0].enabled = false;
              break;
          case 1:
              
              rSpawn.T.GetComponentsInChildren<AudioSource>()[1].clip = Whispers;
			  rSpawn.T.GetComponentsInChildren<AudioSource>()[1].Play();
              break;
          case 2:
             

              break;
		  case 3:
                          rSpawn.T.GetComponentsInChildren<AudioSource>()[1].clip = Buzzing;
			  rSpawn.T.GetComponentsInChildren<AudioSource>()[1].Play();

              break;
		  case 4:
		     
             

              break;

		  case 5:
             
              break;
          default:
             

              break;			  
      }
	  AnswerSelected();
	   

	}
	public void YesAnswer(int num)
	{
		gameObject.GetComponent<AudioSource>().PlayOneShot(click);
	num  = RandEvent;
		RoomSpawning rSpawn = gameObject.GetComponent<RoomSpawning>();
		rSpawn.SpawnRoom();
		rSpawn.T.GetComponentsInChildren<AudioSource>()[1].Stop();
      switch (num)
      {
		  case 0:
              
              rSpawn.T.GetComponentsInChildren<Light>()[0].enabled = true;
              break;
          case 1:
              Instantiate(Necronomicon, rSpawn.T.transform.position, Quaternion.identity);
              
              break;
          case 2:
             GameObject newFren = Instantiate(CatPoster, rSpawn.T.transform.position + new Vector3(2.38f,0.854f,-2.142f), Quaternion.identity);

              break;
		  case 3:
             rSpawn.T.GetComponentsInChildren<AudioSource>()[1].clip = Jazz;
			 rSpawn.T.GetComponentsInChildren<AudioSource>()[1].Play();

              break;
		  case 4:

              GameObject newPlant = Instantiate(Plant, rSpawn.T.transform.position + new Vector3(Random.Range(-3f,3f),1f,Random.Range(-3f,3f)), Quaternion.identity);
              newPlant.transform.parent = rSpawn.T.transform;
			  
            

              break;

			   case 5:
           
			  
            

              break;
          default:
             

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
