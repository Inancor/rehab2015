using UnityEngine;
using System.Collections;

public class ScoreBoardAdd : MonoBehaviour {

    public TextMesh ScoreboardBallsThrown;
    private int count = 0;

    void Start()
    {
        this.count--;
        this.AddValue();
    }

	public void AddValue()
    {
        count++;
        this.ScoreboardBallsThrown.text = this.count.ToString();
    }
}
