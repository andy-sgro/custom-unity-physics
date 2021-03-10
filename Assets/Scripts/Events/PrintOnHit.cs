using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintOnHit : MonoBehaviour
{
	public Text textBox;
	public string message;
	public string tagToHit;


	void Start()
	{
		textBox.text = "";
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("lava");
		if (other.gameObject.CompareTag(tagToHit))
		{
			textBox.text = message;
		}
	}
}
