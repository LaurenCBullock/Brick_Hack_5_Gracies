using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class WegmansAPIManager : MonoBehaviour
{
    StreamReader streamReader;
    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText()
    {
        UnityWebRequest www = new UnityWebRequest("https://api.wegmans.io/meals/recipes?api-version=2018-10-18&Subscription-Key=4a23391d46eb4bd4978fb576d77df423");
        www.downloadHandler = new DownloadHandlerFile("recipeList.JSON");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            // Show results as text
            streamReader = new StreamReader("recipeList.JSON");
            Debug.Log(streamReader.Peek());
            
        }
    }
}