/*
* FILE			: FollowMouse.cs
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the FollowMouse class.
*				  This script makes the attached object follow the mouse cursor.
*/

using UnityEngine;

/**
* NAME	  : FollowMouse
* PURPOSE : 
*	- This script makes the attached object follow the mouse cursor.
*/
public class FollowMouseY : MonoBehaviour
{
	/**
	* \brief	Makes the attached object follow the mouse cursor.
	*
	* \param	void
	*
	* \return	void
	*/
	void FixedUpdate()
    {
		float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
		transform.position = new Vector3(transform.position.x, y);
	}
}
