using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataVerify : MonoBehaviour
{
    public InputField nombre;
    public InputField password;

    public void Verify()
    {
        if (nombre.text == DataRead.instance.datos.user)
        {
            if(password.text == DataRead.instance.datos.password)
            {
                Loader.instance.LoadScene(2);
            }
        }
    }
}
