using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XBoundary : MonoBehaviour
{
    public float leftBound;
    public float rightBound;

    // Update is called once per frame
    void Update()
    {
		float x = transform.position.x;
		float y = transform.position.y;

		if (x < leftBound)
		{
			transform.position = new Vector3(leftBound, y);
		}
		if (x > rightBound)
		{
			transform.position = new Vector3(rightBound, y);
		}
	}
}
