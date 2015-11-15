using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
	public static BallType[] ballTypes = 
	{
		new BallType("CubeBall/CubeBall"),
		new BallType("CylinderBall/CylinderBall")
	};

	public static Ball getNewRandomBall()
	{
		int ballTypeIndex = (int)(Random.value * ballTypes.Length);
		BallType ballType = ballTypes[ballTypeIndex];
		GameObject modelInstance = Instantiate(Resources.Load(ballType.ModelName, typeof(GameObject))) as GameObject;
		Ball ball = modelInstance.GetComponent<Ball>();
		return ball;
	}

	public AudioClip launchAudio;
	public AudioClip catchAudio;

	private AudioSource audioSource;

	//public BallType BallType;

	// Use this for initialization
	void Start ()
	{
		audioSource = this.gameObject.AddComponent<AudioSource>();

		//GetComponent<Rigidbody>().AddForce(new Vector3(0f, 100f, -100f));

		playLaunchSound();
	}

	// Update is called once per frame
	void Update () {

		if (transform.position.z < -2)
		{
			Destroy(this.gameObject);
		}
	}

	public void playLaunchSound()
	{
		audioSource.PlayOneShot(launchAudio);
	}

	public void playCatchSound()
	{
		audioSource.PlayOneShot(catchAudio);
	}
}

