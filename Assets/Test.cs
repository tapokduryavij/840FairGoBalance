using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class Test : MonoBehaviour
{
    private IEnumerator Start()
    {
        UnityWebRequest webRequest = UnityWebRequest.Get("http://localhost:5000/?code=es");
        yield return webRequest.SendWebRequest();
        Debug.LogFormat("{0}", webRequest.downloadHandler.text);
    }
}
