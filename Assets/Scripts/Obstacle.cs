using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	void Update()
	{
		transform.position += transform.forward * Random.Range(6, 8) * Time.deltaTime;
		if (transform.position.z > 30)
			Destroy(gameObject);

	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log("Hit");
		var tank = other.GetComponent<Tank>();
		if (other.GetComponent<Tank>() != null)
		{
			tank.OnHit();
			OnHit();
		}

	}

	void OnHit()
	{
		//ParticleSpawner.Spawn();
		Destroy(gameObject);
	}
}
