using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class WegmansAPIManager : MonoBehaviour
{
    void Start()
    {
        // A correct website page.
        StartCoroutine(GetRequest("https://api.wegmans.io/meals/recipes?api-version=2018-10-18&Subscription-Key=d3e209e9e5aa42fc8cda48193b56255e"));
    }

    IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            if (webRequest.isNetworkError)
            {
                Debug.Log(pages[page] + ": Error: " + webRequest.error);
            }
            else
            {
                Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);
            }
        }
    }
    //private StreamReader streamReader;
    //
    //void Start()
    //{
    //    StartCoroutine(DownloadFile());
    //}
    //
    //IEnumerator DownloadFile()
    //{
    //    var uwr = new UnityWebRequest("https://api.wegmans.io/meals/recipes?api-version=2018-10-18&Subscription-Key=d3e209e9e5aa42fc8cda48193b56255e", UnityWebRequest.kHttpVerbGET);
    //    string path = ("recipeList.Json");
    //    uwr.downloadHandler = new DownloadHandlerFile(path);
    //    yield return uwr.SendWebRequest();
    //    if (uwr.isNetworkError || uwr.isHttpError)
    //        Debug.LogError(uwr.error);
    //    else
    //    {
    //        Debug.Log("File successfully downloaded and saved to " + path);
    //        streamReader = new StreamReader(path);
    //
    //        Debug.Log(streamReader.ReadLine());
    //    }
    //        
    //}
}