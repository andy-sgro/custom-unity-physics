/*
* FILE			: Fader.c
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the Fader class.
*				  It makes the attached object fade when a circle collides with it.
*/

using UnityEngine;


/**
* NAME	  : Fader
* PURPOSE : 
*	- This script makes the attached object fade when a circle collides with it.
*	- This is modeled after dead bad guys in video games, because they seem to 
*	  fade when they're killed.
*/
public class Fader : MonoBehaviour
{
	public int fadeTime;
	public string tagToReactTo;

	private bool startFading;
	private float fadeDelta;

	/**
	* \brief	Sets the object as not hit, and will therefore
	*			not fade right away.
	*
	* \param	void
	*
	* \return	void
	*/
	void Start()
    {
		// if they don't specify a hit condition, fade right away
		if (tagToReactTo != null)
		{
			startFading = (tagToReactTo.Length > 0) ? false : true;
		}
    }




	/**
	* \brief	Checks if this object has been hit, and if it has
	*			then this object fades.
	*
	* \param	void
	*
	* \return	void
	*/
	void Update()
    {
        if (startFading)
		{
			GetComponent<SpriteRenderer>().color -= new Color(0, 0, 0, fadeTime * Time.deltaTime);
			if (GetComponent<SpriteRenderer>().color.a <= 0f)
			{
				Destroy(this.gameObject);
			}
		}
    }



	/**
	* \brief	When this object collides with a circle,
	*			its 'wasHit' property gets set to true,
	*			which makes it fade.
	*
	* \param	Collider2D other : The object that collided with this.
	*
	* \return	void
	*/
	void OnTriggerEnter2D(Collider2D other)
	{
		if ((tagToReactTo != null) && (other.gameObject.tag != null))
		{
			if (other.gameObject.tag.Equals(tagToReactTo))
			{
				startFading = true;
			}
		}
	}


	void LateUpdate()
	{
		if (startFading)
		{
			tag = "Untagged";
		}
	}
}
