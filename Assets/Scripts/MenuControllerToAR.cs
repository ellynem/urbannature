using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Methode zum Laden der AR-Szene mit dem entsprechenden Objekt
    public void LoadARScene(string AR)
    {
        // Hier können Sie Informationen über das gewählte Objekt speichern oder übergeben
        // ...

        // Laden der AR-Szene
        SceneManager.LoadScene(AR);
    }
}

