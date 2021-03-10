/*
* FILE			: CameraController.cs
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the CameraController class, 
*				  which follows the player.
*/

using UnityEngine;


/**
* NAME	  : CameraContoller
* PURPOSE : 
*	- This class goes on cameras, and follow the player.
*	- It's modelled after the cameras in third-person video games.
*/
public class CameraContoller : MonoBehaviour
{
	public GameObject player;

	private Vector3 playerPosDelta;


	/**
	* \brief	Sets our relative offset postion from the player.
	*
	* \details	This offset value is saved and maintained.
	*
	* \param	void
	*
	* \return	void
	*/
	void Start()
    {
		playerPosDelta = transform.position - player.transform.position;
	}


	/**
	* \brief	Moves the camera so it's looking at the player.
	*
	* \details	The saved offset value is used here.
	*
	* \param	void
	*
	* \return	void
	*/
	void LateUpdate()
    {
		transform.position = player.transform.position + playerPosDelta;
    }
}
