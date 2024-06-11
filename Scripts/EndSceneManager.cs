using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text lastScoreText;
    public Text highScoreText;
    int highScore;
    int lastScore;

    void Start() {
        lastScore = PlayerPrefs.GetInt("score");
        lastScoreText.text = lastScore.ToString();

        if (PlayerPrefs.HasKey("highScore") == true)
        {
            highScore = PlayerPrefs.GetInt("highScore");
            if(highScore < lastScore)
            {
                highScore = lastScore;
                PlayerPrefs.SetInt("highScore",highScore);
            }
        }
        else
        {
            highScore = lastScore;
            PlayerPrefs.SetInt("highScore", highScore);
        }
        highScoreText.text = highScore.ToString();

    }
    public void RetryButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
