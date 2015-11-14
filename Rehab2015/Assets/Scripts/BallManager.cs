using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	public Ball spawnObject;
	public Vector3 spawnCentre;
	public float spawnRadius;
	public Vector3 startingVelocity;
	public float ballDelay;

	private float timeUntilNextBall = 0;


	// Update is called once per frame
	void Update () {

		timeUntilNextBall -= Time.deltaTime;

		if (timeUntilNextBall < 0)
		{
			timeUntilNextBall = ballDelay;

			float x = spawnCentre.x + 2 * (Random.value - 0.5f) * spawnRadius;
			float y = spawnCentre.y + 2 * (Random.value - 0.5f) * spawnRadius;
			float z = spawnCentre.z + 2 * (Random.value - 0.5f) * spawnRadius;
			Vector3 spawnPosition = new Vector3(x, y, z);
			//Instantiate(spawnObject, spawnPosition, Quaternion.identity);

			Ball ball = Instantiate<Ball>(spawnObject);
			ball.transform.position = spawnPosition;
			ball.setVelocity(startingVelocity);
		}
	}
}
