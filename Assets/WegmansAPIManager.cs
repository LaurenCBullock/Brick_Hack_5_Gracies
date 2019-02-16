using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class WegmansAPIManager : MonoBehaviour
{
    
    private StreamReader streamReader;
    private RecipeListReader recipeList;
    
    void Start()
    {
        StartCoroutine(DownloadFile());
    }
    
    IEnumerator DownloadFile()
    {
        var uwr = new UnityWebRequest("https://api.wegmans.io/meals/recipes?api-version=2018-10-18&Subscription-Key=d3e209e9e5aa42fc8cda48193b56255e", UnityWebRequest.kHttpVerbGET);
        string path = ("recipeList.Json");
        uwr.downloadHandler = new DownloadHandlerFile(path);
        yield return uwr.SendWebRequest();
        if (uwr.isNetworkError || uwr.isHttpError)
            Debug.LogError(uwr.error);
        else
        {
            Debug.Log("File successfully downloaded and saved to " + path);
            

        }
            
    }
}