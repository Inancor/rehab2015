using UnityEngine;
using System.Collections;

public class FlashController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        explode();

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void explode ()
    {
        var exp = GetComponent<ParticleSystem>();
        exp.Play();
        Destroy(gameObject, exp.duration);
    }
}
