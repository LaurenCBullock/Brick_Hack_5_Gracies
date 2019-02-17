using UnityEngine;
using LitJson;
using System;
using System.Collections;


public class wegmansJsonGet : MonoBehaviour {

    public static void Main() {
        var fromJson = "{\"recipes\":[{\"id\":21407,\"name\":\"Asian Cauliflower \\\"Rice\\\" Lettuce Wraps\",\"_links\":[{\"href\":\"/meals/recipes/21407/?api-version=2018-10-18\",\"rel\":\"self\",\"type\":\"GET\"}]},{\"id\":21472,\"name\":\"Beef Fajitas\",\"_links\":[{\"href\":\"/meals/recipes/21472/?api-version=2018-10-18\",\"rel\":\"self\",\"type\":\"GET\"}]}]}";
        var fromObject = LitJson.JsonMapper.ToObject<RecipeList>(fromJson);
        Debug.Log(fromJson);
    }

    [System.Serializable]
    public class RecipeList
    {
        public Recipe recipe;
        public static RecipeList CreateFromJSON(string json)
        {
            return JsonUtility.FromJson<RecipeList>(json);
        }
    }

    [System.Serializable]
    public class Recipe
    {
        public string id;
        public string name;
        public Links _links;
    }


    [System.Serializable]
    public class Links
    {
        public string href;
        public string rel;
        public string type;
    }
}
