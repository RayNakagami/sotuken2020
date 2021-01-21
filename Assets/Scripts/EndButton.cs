using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndButton : MonoBehaviour
{
    public GameObject textbox;
    private Text scoreBord;

    void Start()
    {
        this.scoreBord = textbox.GetComponent<Text>();
        int score = PlayerPrefs.GetInt("SCORE");

        scoreBord.text = "SCORE:" + score.ToString();
    }
    public void Onclick()
    {
        //ここで移りたいシーンを指定します。
        SceneManager.LoadScene("Title");
    }
}