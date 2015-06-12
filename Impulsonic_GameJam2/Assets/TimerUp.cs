using UnityEngine;
using System.Collections;
using System;

public class TimerUp : MonoBehaviour{

	public static float TimeElapsed = 0;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		TimeElapsed += Time.deltaTime;
	}

	void OnGUI() {
		GUI.Label (new Rect (830, 150, Screen.width, Screen.height), ((int)TimerUp.TimeElapsed + 
		                                                              "secs!"));
	}


}

