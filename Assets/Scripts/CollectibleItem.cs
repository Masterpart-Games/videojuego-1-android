using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
	public GameObject lightingParticles;
	public GameObject burstParticles;


	public int health = 1;

	private SpriteRenderer _rederer;
	private Collider2D _collider;

	private void Awake()
	{
		_rederer = GetComponent<SpriteRenderer>();
		_collider = GetComponent<Collider2D>();

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player")) {

			collision.SendMessageUpwards("AddHealth", health);

			_collider.enabled = false;

			_rederer.enabled = false;
			lightingParticles.SetActive(false);
			burstParticles.SetActive(true);

			Destroy(gameObject, 2f);
		}
	}
}