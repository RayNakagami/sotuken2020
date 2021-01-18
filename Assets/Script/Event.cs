using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Event : MonoBehaviour
{
    int score;
    float seconds;
    private Text scoreBord;

    public GameObject textbox;

    public GameObject tree0;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    // Start is called before the first frame update
    void Start()
    {
        this.seconds = 0.0f;
        this.score = 0;
        this.scoreBord = textbox.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 2)
        {
            int a = (int)(Random.Range(0, 4));
            if (a < 4)
            {
                if (a == 0)
                {
                    tree0.GetComponent<Tree>().SetSemi();
                }
                else if (a == 1)
                {
                    tree1.GetComponent<Tree>().SetSemi();
                }
                else if (a == 2)
                {
                    tree2.GetComponent<Tree>().SetSemi();
                }
                if (a == 3)
                {
                    tree3.GetComponent<Tree>().SetSemi();
                }

                seconds = 0.0f;
                // Debug.Log(a);
            }
        }
    }

    public void AddScore()
    {
        score++;
        scoreBord.text = "SCORE:" + score.ToString();
    }
}
