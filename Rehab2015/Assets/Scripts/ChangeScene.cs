using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public string LevelName;

    // Use this for initialization
	void Start () {
	}
	
    public void ChangeLevel()
    {
        Application.LoadLevel(LevelName);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
