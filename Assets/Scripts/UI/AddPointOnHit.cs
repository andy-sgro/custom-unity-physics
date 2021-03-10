/*
* FILE			: Level1UI.cs
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the Level1UI class,
*				  which displays points on the screen as a HUD.
*/


using UnityEngine;
using UnityEngine.UI;

/**
* NAME	  : Level1UI
* PURPOSE : 
*	- This is the UI HUD for level 1.
*	- It displays points and when the player wins.
*	- Attach this script to the object that collects points.
*/
public class AddPointOnHit : MonoBehaviour
{
	[SerializeField] private Text countText;
	[SerializeField] private Text winText;
	[SerializeField] private int goal;
	[SerializeField] private string tagToHit;
	[SerializeField] private bool disapearOnWin;
	[SerializeField] private PauseMenu pauseMenu = null;
	private int points;
	private bool didWin = false;
	private double winCountdown = 1.5;

	/**
	* \brief	Sets the variables and displays the HUD.
	*
	* \param	void
	*
	* \return	void
	*/
	void Start()
    {
		points = 0;
		winText.text = "";

		UpdateCountText();
	}



	/**
	* \brief	When this object collides with coins, increment the points and
	*			display it.
	*
	* \param	void
	*
	* \return	void
	*/
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagToHit))
		{
			++points;
			UpdateCountText();
		}
	}



	/**
	* \brief	Updates the HUD so the user can see how
	*			many points they collected.
	*
	* \param	void
	*
	* \return	void
	*/
	void UpdateCountText()
	{
		countText.text = "Count: " + points.ToString();
		if (points >= goal)
		{
			didWin = true;
			winText.text = "You win!";
			if (disapearOnWin)
			{
				GetComponent<Fader>().enabled = true;
			}
		}
	}

	private void Update()
	{
		if (didWin)
		{
			winCountdown -= Time.deltaTime;
			if (winCountdown <= 0)
			{
				pauseMenu.Pause();
			}
		}
	}

}
