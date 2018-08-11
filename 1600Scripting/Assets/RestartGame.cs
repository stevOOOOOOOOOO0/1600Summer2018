using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour
{
	private Button restartButton;

	void Start()
	{
		restartButton = GetComponent<Button>();
		restartButton.onClick.AddListener(TaskOnClick);
	}
	
	private void TaskOnClick()
	{
		Debug.Log("GG man");
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
