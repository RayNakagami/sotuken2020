using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    int score;

    private Text scoreBord;

    public GameObject textbox;
    // Start is called before the first frame update
    void Start()
    {
        this.score = 0;
        this.scoreBord = textbox.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScore()
    {
        score++;
        scoreBord = "SCORE:" + score.ToString();
    }
}
