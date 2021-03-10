/*
* FILE			: Velocity.cs
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the Velocity class, 
*				  which an abstraction layer for the Vector2 and Physics classes.
*				  It contains a vector which represents velocity (direction and speed).
*/

using UnityEngine;


/**
* NAME	  : Velocity.cs
* PURPOSE : 
*	- This is an astraction layer for the Vector2 and Physics classes.
*	- It contain a vector which represents velocity (direction and speed).
*/
public class Velocity
{
	private Vector2 vel;

	/**
	* \brief	Instantiates this object, given a Vector2 object,
	*			which represents velocity.
	*
	* \param	Vector2 velocity : The value of this object
	*
	* \return	Returns a Velocity object.
	*/
	public Velocity(Vector2 velocity)
	{
		vel = velocity;
	}



	/**
	* \brief	Instantiates this object, given a an
	*			angle and speed.
	*
	* \param	float angle : The angle of this object.
	* \param	float speed	: The speed of this object.
	*
	* \return	Returns a Velocity object.
	*/
	public Velocity(float angle, float speed)
	{
		vel = Physics.GetVelocity(angle, speed);
	}



	/**
	* \brief	Simulates bouncing off walls.
	*
	* \param	Physics.Direction wallPlacement : Where the wall it,
	*			relative to the object that holds this velocity
	*
	* \return	void
	*/
	public void Reflect(Physics.Direction wallPlacement)
	{
		vel = Physics.CircleBounce(vel, wallPlacement);
	}


	/**
	* \brief	Simulates bouncing off balls.
	*
	* \param	Vector2 selfPos  : The position of the object that holds this velocity.
	* \param	Vector2 otherPos : The position of the object that the other object
	*							   is bouncing against.
	*
	* \return	void
	*/
	public void Reflect(Vector2 selfPos, Vector2 otherPos)
	{
		vel = Physics.CircleBounce(vel, selfPos, otherPos);
	}




	/**
	* \brief	Gets or sets the vector/velocity of this object.
	*/
	public Vector2 Vector
	{
		get
		{
			return vel;
		}
		set
		{
			vel = value;
		}
	}


	/**
	* \brief	Gets or sets the speed of this object.
	*/
	public float Speed
	{
		get
		{
			return Physics.GetSpeed(vel);
		}
		set
		{
			vel = Physics.SetSpeed(vel, value);
		}
	}


	/**
	* \brief	Gets or sets the angle of this object.
	*/
	public float Angle
	{
		get
		{
			return Physics.GetAngle(vel);
		}
		set
		{
			vel = Physics.SetAngle(vel, value);
		}
	}



}
