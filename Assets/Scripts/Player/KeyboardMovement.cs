/*
* FILE			: KeyboardMovement.cs
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the KeyboardMovement class, 
*				  which allows the attached object to be moved via the keyboard.
*/

using UnityEngine;


/**
* NAME	  : KeyboardMovement
* PURPOSE : 
*	- This script allows the attached object to be moved via the keyboard.
*	- Attach this to the player object for maximum fun!
*/
public class KeyboardMovement : MonoBehaviour
{
	
	public float speed;
	private Rigidbody2D rb2d;

	/**
	* \brief	Gain access to the rigid body physics component.
	*
	* \param	void
	*
	* \return	void
	*/
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
	}

	/**
	* \brief	Move the object with the keyboard.
	*
	* \param	void
	*
	* \return	void
	*/
	void FixedUpdate()
	{
		// get input from keyboard
		float moveX = Input.GetAxis("Horizontal");
		float moveY = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(moveX, moveY);
		rb2d.AddForce(movement * speed);
	}
}
