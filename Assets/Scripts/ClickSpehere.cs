﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickSpehere : MonoBehaviour {
	public GameObject UserInt;


//	void Start () {
//		Canvas speach = UIthingy.GetComponent<Canvas>();
////		Text script = demWords.GetComponent<Text>();
//		speach.onClick.AddListener(TaskOnClick);
//
//
//
//	}
//
//	void TaskOnClick(){
//		Text script = demWords.GetComponent<Text>();
//	}

	void OnMouseDown(){
		UserInt.SetActive(true);
	}

} 