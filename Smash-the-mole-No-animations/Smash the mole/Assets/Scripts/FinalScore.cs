using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;

    private void OnEnable()
    {
        finalScoreText.text = "Score: " + FindObjectOfType<GameManager>().finalScore.ToString();
    }

}
