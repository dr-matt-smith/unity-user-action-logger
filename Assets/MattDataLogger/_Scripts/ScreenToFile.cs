using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenToFile : MonoBehaviour
{

	private Text textInput;

	private void Awake()
	{
		textInput = GetComponent<Text>();
	}

	public void BUTTON_ACTION_LogTextToFile()
	{
		AddToLogFile.LogLine(textInput.text);
	}

	public void BUTTON_ACTION_CreateTextFileWithUserId()
	{
		AddToLogFile.userNumber = textInput.text;
		AddToLogFile.CreateNewLogFileWithId(textInput.text);
	}
	
	public void BUTTON_ACTION_Scene2()
	{
		// Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
		SceneManager.LoadScene("scene2");
	}

	
}
