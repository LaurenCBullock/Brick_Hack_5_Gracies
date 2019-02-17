using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RecipeListReader
{
    public string name;

    public RecipeListReader()
    {

    }

    public static RecipeListReader CreateFromJSON(string jsonString)
    {
        return JsonUtility.FromJson<RecipeListReader>(jsonString);
    }

    // Given JSON input:
    // {"name":"Dr Charles","lives":3,"health":0.8}
    // this example will return a PlayerInfo object with
    // name == "Dr Charles", lives == 3, and health == 0.8f.
}
