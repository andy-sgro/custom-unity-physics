using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateOnHit : MonoBehaviour
{
	public string tagToDeactivate;

	GameObject wasHit;
	
	// Start is called before the first frame update
    void Start()
    {
		wasHit = null;
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagToDeactivate))
		{
			wasHit = other.gameObject;
		}
	}

	// Update is called once per frame
	void LateUpdate()
    {
        if (wasHit)
		{
			wasHit.SetActive(false);
		}
    }
}
