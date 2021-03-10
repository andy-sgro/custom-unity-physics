using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorOptions : MonoBehaviour
{
	public bool visible;
	
	// Start is called before the first frame update
    void Start()
    {
		Cursor.visible = visible;

	}

	public void SetInvisible()
	{
		Cursor.visible = false;
	}

	public void SetVisible()
	{
		Cursor.visible = true;
	}

}
