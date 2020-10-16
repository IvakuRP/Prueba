using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimonManager : MonoBehaviour
{
    public SpriteRenderer[] colorsButtons;

    private int colorSelect;

    public float stayLit;
    private float stayLitCount;

    void Update()
    {
        if (stayLitCount > 0)
        {
            stayLitCount -= Time.deltaTime;
        }    
        else
        {
            colorsButtons[colorSelect].color = new Color(colorsButtons[colorSelect].color.r,
            colorsButtons[colorSelect].color.g, colorsButtons[colorSelect].color.b,150);
        }
    }

    public void StartGame()
    {
        colorSelect = Random.Range(0, colorsButtons.Length);

        colorsButtons[colorSelect].color = new Color(colorsButtons[colorSelect].color.r,
            colorsButtons[colorSelect].color.g, colorsButtons[colorSelect].color.b,255);

        stayLitCount = stayLit;
    }

    public void Menu()
    {
        Loader.instance.LoadScene(2);
    }
}
