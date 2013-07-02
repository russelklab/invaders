using UnityEngine;
using System.Collections;

public class GibOnCollide : MonoBehaviour {
	
	public GameObject[] gibs;
	public float explosionforce;
	public float spawnRadius = 1.0f;
	
	void OnTriggerEnter () {
		foreach (GameObject gib in gibs) 
		{
			GameObject gibInstance = Instantiate(gib, transform.position + Random.insideUnitSphere * spawnRadius, transform.rotation) as GameObject;
			gibInstance.rigidbody.AddExplosionForce(explosionforce, transform.position, spawnRadius);
		}
		Destroy (gameObject);
	}
}
