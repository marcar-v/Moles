using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            TimerStart(5.0f);
        }

    }
    public void TimerStart(float time)
    {
        StartCoroutine(TimerRoutine(time));
    }
    IEnumerator TimerRoutine (float time)
    {
        float actualTime = time;
        while (actualTime > 0)
        {
            actualTime -= Time.deltaTime;
            timerText.text = actualTime.ToString("F2");

            yield return null;
        }

        timerText.text = "Time over";

        Events.EventTimeOver();
    }
}
