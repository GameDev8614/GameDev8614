using System;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] private int _scoreNumber = 0;
    public int ScoreNumber => _scoreNumber;
    [SerializeField] private Text _scoreText;

    private void Start()
    {
        UpdateScore();
    }

    public void UpdateScore()
    {
        _scoreText.text = $"Score: {_scoreNumber.ToString()}";
    }

    public void IncreaseScore()
    {
        _scoreNumber++;
        UpdateScore();
    }
}
