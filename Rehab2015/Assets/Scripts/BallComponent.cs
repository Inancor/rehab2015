using UnityEngine;
using System.Collections;

public class BallComponent : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private GameObject ball;

    private Vector3 startSpace;

    public int killRadius = 25;

	private Vector3 gravity = new Vector3(0, -0.0075f, 0);
    private GameObject modelInstance;

	private Vector3 velocity = new Vector3(0, 0, -0.04f);
	private Quaternion tumble = Quaternion.AngleAxis(1.0f, new Vector3(0.5f, 0.3f, 0.7f));

	// Use this for initialization
	void Start ()
	{
        //Create();
	}

    public void Create(Vector3 position, Vector3 velocity)
    {
        //int ballIndex = (int)(Random.value * ballPrefabs.Length);
        int ballIndex = (int)Random.Range(0, ballPrefabs.Length - 1);
        ball = ballPrefabs[ballIndex];

        modelInstance = Instantiate(ball);
        modelInstance.transform.SetParent(this.transform, false);

        this.startSpace = modelInstance.transform.position;

        Debug.Log("Ball start point: " + this.startSpace);

        //GetComponentInParent<AudioSource>().PlayOneShot(    )
        playLaunchSound();
    }

	// Update is called once per frame
	void Update () {

		Vector3 gravityDelta = gravity * Time.deltaTime;

		//velocity = velocity + new Vector3(0, -0.00015f, 0);
		velocity = velocity + gravityDelta;
		velocity = velocity * 0.999f;

		//this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 0.04f);
		modelInstance.transform.position = this.transform.position + velocity;


        modelInstance.transform.Rotate(tumble.eulerAngles);

        if (Vector3.Distance(modelInstance.transform.position, this.startSpace) > this.killRadius)
		{
            Debug.Log("Destroying ball");
			Destroy(this.modelInstance);
		}
	}

	public void setVelocity(Vector3 velocity)
	{
		this.velocity = velocity;
	}

	public void playLaunchSound()
	{
		//GetComponent<AudioSource>().PlayOneShot(BallType.launchAudioClip);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(ball.GetComponent<CollisionSound>().CollideSound);
    }

	public void playCatchSound()
	{
		//GetComponent<AudioSource>().PlayOneShot(BallType.catchAudioClip);
        Camera.main.GetComponent<AudioSource>().PlayOneShot(ball.GetComponent<CollisionSound>().CollideSound);
	}

	//test
}

