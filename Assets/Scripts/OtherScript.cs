using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenu;    // Referenz zum Hauptmenü-UI
    public GameObject arContent;   // Referenz zu den AR-Inhalten

    private void Start()
    {
        // Stelle sicher, dass das Hauptmenü aktiviert und AR-Inhalte deaktiviert sind beim Start
        mainMenu.SetActive(true);
        arContent.SetActive(false);
    }

    // Wird aufgerufen, wenn eine Kategorie im Hauptmenü ausgewählt wird
    public void OnARContentSelected()
    {
        // Deaktiviere das Hauptmenü und aktiviere die AR-Inhalte
        mainMenu.SetActive(false);
        arContent.SetActive(true);

        // Hier kannst du zusätzliche Logik einfügen, um spezifische AR-Inhalte zu laden
    }

    // Wird aufgerufen, um zum Hauptmenü zurückzukehren
    public void OnReturnToMainMenu()
    {
        // Deaktiviere die AR-Inhalte und aktiviere das Hauptmenü
        arContent.SetActive(false);
        mainMenu.SetActive(true);
    }
}