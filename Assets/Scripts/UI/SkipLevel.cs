﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipLevel : MonoBehaviour
{
	public int sceneToLoad;
	
	// Start is called before the first frame update
    void Start()
    {
		SceneManager.LoadScene(sceneToLoad);
	}
}
