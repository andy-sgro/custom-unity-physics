/*
* FILE			: Rotator.cs
* PROJECT		: GAS Final Project
* PROGRAMMER	: Andy Sgro
* FIRST VERSION : April 17, 2019
* DESCRIPTION	: This file contains the definition of the Rotator class, 
*				  which makes the attached object rotate.
*/

using UnityEngine;

/**
* NAME	  : Rotator
* PURPOSE : This script makes the attached object rotate.
*/
public class Rotator : MonoBehaviour
{
	public float rotationSpeed;

	/**
	* \brief	Rotate the attached object.
	* \details	Rotation speed is determined by the public rotationSpeed variable.
	* \param	void
	* \return	void
	*/
	void Update()
    {
		transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }
}
