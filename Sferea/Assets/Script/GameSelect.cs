using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelect : MonoBehaviour
{
    public void Memorama()
    {
        Loader.instance.LoadScene(3);
    }

    public void Simon()
    {
        Loader.instance.LoadScene(4);
    }
}
