﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeOnClick : MonoBehaviour
{
    public void Resume()
	{
		GetComponent<PauseMenu>().Resume();
	}

}
