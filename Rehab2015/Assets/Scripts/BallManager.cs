using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour
{
	//public Ball spawnObject;
	//public Vector3 spawnCentre;
	//public float spawnRadius;
	public float ballDelay;
	public Vector3 fireVector;

	private float timeUntilNextBall;


	void Start () {
	}

	// Update is called once per frame
	void Update () {

		timeUntilNextBall -= Time.deltaTime;

		if (timeUntilNextBall < 0)
		{
			timeUntilNextBall = ballDelay;

			Vector3 spawnPosition = this.transform.position;

			//Ball ball = Instantiate<Ball>(spawnObject);
			Ball ball = Ball.getNewRandomBall();
			ball.transform.position = spawnPosition;
			if (ball.GetComponent<Rigidbody>() == null)
				ball.gameObject.AddComponent<Rigidbody>();
			ball.GetComponent<Rigidbody>().AddForce(fireVector);

			GameObject fireball = this.transform.parent.FindChild("Fireball").gameObject;
			fireball.GetComponent<ParticleSystem>().Play();
		}
	}

	
}
