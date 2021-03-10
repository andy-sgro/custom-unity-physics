using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	
	public GameObject pauseMenuUI;
	private bool paused = false;


	void Awake()
	{
		paused = false;
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
	}

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (paused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
    }

	public void Resume()
	{
		Cursor.visible = false;
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		paused = false;
	}

	public void Pause()
	{
		Cursor.visible = true;
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		paused = true;
	}
}
