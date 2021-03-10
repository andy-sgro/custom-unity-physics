/*
* FILE			: TouchBall.cs
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the TouchBall class, 
*				  which makes the attached object follow the ball.
*/

using UnityEngine;

/**
* NAME	  : TouchBall
* PURPOSE : This class tests the Physics.TouchCircle() function.
*/
public class TouchBall : MonoBehaviour
{


	/**
	 * \brief	Tests the Physics.TouchCircle() function.
	*/
	void FixedUpdate() // regressed
    {
		GameObject player = GameObject.Find("Bouncer");
		Vector2 playerPos = player.transform.position;
		float radius = transform.GetComponent<CircleCollider2D>().radius;
		float playerRadius = player.transform.GetComponent<CircleCollider2D>().radius;

		transform.position = Physics.TouchCircle(transform.position, radius, playerPos, playerRadius);
	}
}
