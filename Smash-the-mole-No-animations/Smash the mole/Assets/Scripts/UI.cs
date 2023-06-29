using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public RectTransform[] screens;

    private void Start()
    {
        CenterScreen();
        ChangeScreen(0);
    }

    public void ChangeScreen(int indiceDePantalla)
    {
        foreach (var screen in screens)
        {
            screen.gameObject.SetActive(false);
        }

        screens[indiceDePantalla].gameObject.SetActive(true);
    }

    void CenterScreen()
    {
        foreach (var screen in screens)
        {
            screen.offsetMin = Vector2.zero;
            screen.offsetMax = Vector2.one;
        }
    }
}
