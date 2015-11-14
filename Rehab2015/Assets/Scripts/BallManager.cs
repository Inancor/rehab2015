using UnityEngine;
using System.Collections;

public class BallManager : MonoBehaviour {

	public BallComponent spawnObject;
	public Vector3 spawnCentre;
	public float spawnRadius;
	public Vector3 startingVelocity;
	public float ballDelay;

    public ScoreBoardAdd ThrownBalls;

	private float timeUntilNextBall;


	// Use this for initialization
	void Start () {
        //TODO: Change this to cannon transform, not previous ball transform
        spawnCentre = this.gameObject.transform.position;
        Debug.Log(gameObject.name);
	}

	// Update is called once per frame
	void Update () {

		timeUntilNextBall -= Time.deltaTime;

		if (timeUntilNextBall < 0)
		{
			timeUntilNextBall = ballDelay;

			float x = spawnCentre.x + 2 * (Random.value - 0.5f) * spawnRadius;
			float y = spawnCentre.y + 2 * (Random.value - 0.5f) * spawnRadius;
			float z = spawnCentre.z + 2 * (Random.value - 0.5f) * spawnRadius;
			//Vector3 spawnPosition = new Vector3(x, y, z);

            Vector3 spawnPosition = spawnCentre;
            
            //Instantiate(spawnObject, spawnPosition, Quaternion.identity);

            //BallComponent ball = Instantiate<BallComponent>(spawnObject);
            spawnObject.Create(spawnPosition, startingVelocity);
            //ball.transform.position = spawnPosition;
			//ball.setVelocity(startingVelocity);

			if(this.ThrownBalls != null)
            {
                this.ThrownBalls.AddValue();
            }
		}
	}

	
}
