/*
* FILE			: Bouncer.ca
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the Bouncer class.
*				  It's purpose is to bounce against circles, and be affected by
*				  gravitational orbital mechanics.
*/


using UnityEngine;


/**
* NAME	  : Bouncer
* PURPOSE : 
*	- The purpose of this class is to bounce against circles, and be affected by
*	  gravitational orbital mechanics.
*	- This class is modelled after the planets in the solar system.
*	- This class uses the Velocity and Physics classes.
*/
public class Bouncer : MonoBehaviour
{
	public float speed;
	public float angle;
	public string colliderTag;

	private Velocity velocity;



	/**
	* \brief	Sets this object's movement vector.
	*
	* \param	void
	*
	* \return	void
	*/
	void Start()
    {
		velocity = new Velocity(angle, speed);
	}


	/**
	* \brief	Moves the object.
	*
	* \param	void
	*
	* \return	void
	*/
	void FixedUpdate()
    {
		transform.Translate(velocity.Vector * Time.fixedDeltaTime);
	}


	/**
	* \brief	This is the collision detection.
	*
	* \details	Please give me a jump table!
	*
	* \param	Collider2D other : The object that was collided with.
	*
	* \return	void
	*/
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("LWall"))
		{
			velocity.Reflect(Physics.Direction.Left);
		}
		if (other.gameObject.CompareTag("RWall"))
		{
			velocity.Reflect(Physics.Direction.Right);
		}
		if (other.gameObject.CompareTag("Ceil"))
		{
			velocity.Reflect(Physics.Direction.Top);
		}
		if (other.gameObject.CompareTag("Floor"))
		{
			velocity.Reflect(Physics.Direction.Bottom);
		}
		if (other.gameObject.CompareTag(colliderTag))
		{
			BounceCircle(other.gameObject);
		}
	}




	/**
	* \brief	Applies the force to bounce against a circle.
	*
	* \details	This is called when a circle is collided with.
	*
	* \param	GameObject other : The circle that was collided with.
	*
	* \return	void
	*/
	void BounceCircle(GameObject other)
	{
		//float radius = transform.GetComponent<CircleCollider2D>().radius;
		//float otherRadius = other.transform.GetComponent<CircleCollider2D>().radius;
		//transform.position = Physics.TouchCircle(transform.position, other.transform.position, radius, otherRadius);

		velocity.Reflect(transform.position, other.gameObject.transform.position);
	}


	/**
	* \brief	This detects when the object has entered a gravitational field.
	*
	* \details	When the object enters a gravitational field, it orbits around it.
	*
	* \param	Collider2D other : The gravitational field.
	*
	* \return	void
	*/
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("GravityField"))
		{
			float radius = other.transform.GetComponent<CircleCollider2D>().radius;
			if (Physics.GetDistance(transform.position, other.transform.position) < radius)
			{
				Orbit(other.gameObject);
			}
		}
	}


	/**
	* \brief	Orbits a gravitational field.
	*
	* \param	GameObject gravityField : The gravitational field.
	*
	* \return	void
	*/
	void Orbit(GameObject gravityField)
	{
		float gravityRadius = gravityField.transform.GetComponent<CircleCollider2D>().radius;

		velocity.Vector += Physics.GetGravityVector(transform.position, gravityField.transform.position, gravityRadius);
	}




	public Vector2 Vector
	{
		get
		{
			return velocity.Vector;
		}
		set
		{
			velocity.Vector = value;
		}
	}


	
}
