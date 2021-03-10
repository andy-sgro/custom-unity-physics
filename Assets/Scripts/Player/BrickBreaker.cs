using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrickBreaker : MonoBehaviour
{
	private bool wasClicked;

	void Awake()
	{
		wasClicked = false;
	}



    // Update is called once per frame
    void Update()
    {
		if ((!wasClicked) && (Input.GetMouseButtonDown(0)))
		{
			GetComponent<XBoundary>().enabled = false;
			GetComponent<FollowMouseX>().enabled = false;
			GetComponent<Bouncer>().enabled = true;
			wasClicked = true;			
		}
	}

}
