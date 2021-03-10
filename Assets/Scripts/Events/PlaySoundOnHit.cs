using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnHit : MonoBehaviour
{
	public AudioClip clip;
	public string tagToHit;

	private AudioSource source;

	// Start is called before the first frame update
	void Start()
	{
		source = GetComponent<AudioSource>();
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag(tagToHit))
		{
			source.PlayOneShot(clip);
		}
	}
}
