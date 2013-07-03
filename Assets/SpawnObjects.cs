using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {
	
	public GameObject spawnObject;
	public float spawnAreaWidth;
	public float spawnAreaHeight;
	public int numberOfEnemiesX;
	public int numberOfEnemiesY;
	
	// Use this for initialization
	void Start () 
	{
		for (int i = 0; i < numberOfEnemiesX;  i++)
		{
			for (int j = 0; j < numberOfEnemiesY; j++)
			{
				Vector3 spawnPosition = transform.position;
				spawnPosition.x += i * (spawnAreaWidth/numberOfEnemiesX);
				spawnPosition.y += j * (spawnAreaHeight/numberOfEnemiesY);
				Instantiate(spawnObject, spawnPosition, spawnObject.transform.rotation);
			}
		}
	}
	
	void OnDrawGizmos ()
	{
		// DrawLine	
	}
}
