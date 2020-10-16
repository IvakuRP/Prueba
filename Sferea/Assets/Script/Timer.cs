using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public float time = 0.0f;

    void Update()
    {
        time += Time.deltaTime;

        ActualizarReloj(time);
    }

    public void ActualizarReloj(float tiempo)
    {
        int minutos = 0;
        int segundos = 0;
        string textoTiempo;

        if (tiempo < 0)
            tiempo = 0;

        minutos = (int)tiempo / 60;
        segundos = (int)tiempo % 60;

        textoTiempo = minutos.ToString("00") + ":" + segundos.ToString("00");

        timeText.text = textoTiempo;
    }
}
