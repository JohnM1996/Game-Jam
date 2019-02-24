using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Computer : MonoBehaviour 
{
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
       switch (num)
      {
          case 1:
              
              break;
          case 2:
             
              break;
		  case 3:
             
              break;
		  case 4:
             
              break;
          default:
             
              break;
      }
	}
	public void YesAnswer(int num)
	{
      switch (num)
      {
          case 1:
              
              break;
          case 2:
             
              break;
		  case 3:
             
              break;
		  case 4:
             
              break;
          default:
             
              break;
      }
	}

	public void AnswerSelected()
	{
		ComputerScreen.enabled = false;
	}
}
