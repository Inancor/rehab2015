using UnityEngine;
using System.Collections;

public class testBallScript : MonoBehaviour {

    public Vector3 CannonForce;
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate ()
    {

        //rb.AddForce(CannonForce, Impulse);
        rb.AddForce(CannonForce);
    }
}
