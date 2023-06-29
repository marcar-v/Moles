using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] float gameTime = 10;
    [SerializeField] Score score;
    [SerializeField] UI ui;
    [SerializeField] Timer timer;
    [SerializeField] Holes holes;
    public int finalScore;

    private void Start()
    {
        Events.TimeOver += GameOver;
    }
    public void StartGame()
    {
        holes.StartHole();
        timer.TimerStart(gameTime);
    }

    public void GameOver()
    {
        finalScore = score.actualScore;

        score.ResetScore();
        ui.ChangeScreen(2);
        holes.EndHole();

        finalScore = 0;
    }

    private void OnDisable()
    {
        Events.TimeOver -= GameOver;
    }
}
