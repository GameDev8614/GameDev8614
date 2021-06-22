using System;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    [SerializeField] private Text _highScoreTxt;

    [SerializeField] private ScoreCounter _scoreCounter;

    private void Start()
    {
        _highScoreTxt.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void SetHighScore()
    {
        if (_scoreCounter.ScoreNumber > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _scoreCounter.ScoreNumber);
            _highScoreTxt.text = "HighScore: " + _scoreCounter.ScoreNumber.ToString();
        }
       
    }
}
