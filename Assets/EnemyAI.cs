using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	
	public float speed;
	public float rightEdge;
	public float leftEdge;
	private static int direction = 1;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = transform.position;
		newPosition.x += speed * direction * Time.deltaTime;
		transform.position = newPosition;
		
		if (transform.position.x > rightEdge) {
			direction = -1;	
		}
		
		if (transform.position.x < leftEdge) {
			direction = 1;	
		}
	}
}
