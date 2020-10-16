using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataRead : MonoBehaviour
{
    public static DataRead instance;

    [System.Serializable]
    public struct estructuraDatos
    {
        public string user;
        public string password;
    }

    public estructuraDatos datos;

    void Start()
    {
        instance = this;
        Leer();
    }

    public void Leer()
    {
        StartCoroutine(LeerDatos());
    }

    private IEnumerator LeerDatos(){
        UnityWebRequest web = UnityWebRequest.Get("https://raw.githubusercontent.com/Chezzar/PruebaUnityLogin/master/LoginUser");
        yield return web.SendWebRequest();

        if(!web.isNetworkError && !web.isHttpError)
        {
            datos = JsonUtility.FromJson<estructuraDatos>(web.downloadHandler.text);
        }
        else
        {
            Debug.LogWarning("Error");
        }
    }
}
