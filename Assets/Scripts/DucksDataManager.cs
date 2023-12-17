using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class DucksDataManager : MonoBehaviour
{
    public DatabaseDuck DucksDB;
    public SpriteRenderer Image;
    public string API_URL = "https://random-d.uk/api/random";
    public object UnityWebReqest { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetData(API_URL));
    }

    private IEnumerator GetData(string url)
    {
        // Prrpare web request with url
        using UnityWebRequest webRequest = UnityWebRequest.Get(url);
        // send web request and wait until finished
        yield return webRequest.SendWebRequest();
        // check if request was sucessful 
        if(webRequest.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("request finished " + webRequest.downloadHandler.text);
            ParseJSON(webRequest.downloadHandler.text);
        }
    }

    private void ParseJSON(string json)
    {
        DatabaseDuck DucksDB = JsonUtility.FromJson<DatabaseDuck>(json);
        StartCoroutine(GetImage(DucksDB.url));
    }

    private IEnumerator GetImage(string url)
    {
        using UnityWebRequest webRequest = UnityWebRequestTexture.GetTexture(url);
        yield return webRequest.SendWebRequest();
        if (webRequest.result == UnityWebRequest.Result.Success)
        {
            Texture2D texture = DownloadHandlerTexture.GetContent(webRequest);
        }
    }
    private void AssignImage(Texture2D texture)
    {
        Sprite sprite = Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
        Image.sprite = sprite;
    }
}
