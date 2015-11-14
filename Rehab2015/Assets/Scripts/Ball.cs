using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Vector3 gravity = new Vector3(0, -0.0075f, 0);

	private Vector3 velocity = new Vector3(0, 0, -0.04f);

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {

		Vector3 gravityDelta = gravity * Time.deltaTime;

		//velocity = velocity + new Vector3(0, -0.00015f, 0);
		velocity = velocity + gravityDelta;
		velocity = velocity * 0.999f;

		//this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 0.04f);
		this.transform.position = this.transform.position + velocity;

		if (transform.position.z < -2)
		{
			Destroy(this.gameObject);
		}
	}

	public void setVelocity(Vector3 velocity)
	{
		this.velocity = velocity;
	}
}
