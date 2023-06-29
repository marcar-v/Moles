using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int actualScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        Events.SmashedMole += HitMole;
    }
    void HitMole(Mole mole)
    {
        UpdateScore(10);
    }
    public void ResetScore()
    {
        actualScore = 0;
        scoreText.text = actualScore.ToString();
    }
    public void UpdateScore(int score)
    {
        actualScore += score;
        scoreText.text = actualScore.ToString();

    }

    private void OnDisable()
    {
        Events.SmashedMole -= HitMole;
    }

}
