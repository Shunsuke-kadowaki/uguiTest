using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

	public float speedX = 30.0f;
	public float speedY = 40.0f;
	public float speedZ = 50.0f;

	public GameObject Cube;

	private float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer = Time.deltaTime;

		Cube.transform.Rotate(speedX * timer, speedY * timer, speedZ * timer);
	}
}
