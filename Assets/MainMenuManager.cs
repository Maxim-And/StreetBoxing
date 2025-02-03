using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        // Lädt die nächste Szene (z. B. den Kampf)
        SceneManager.LoadScene("Game");
    }

    public void QuitGame()
    {
        Debug.Log("Spiel beendet!");
        Application.Quit(); // Funktioniert nur im Build, nicht im Editor
    }
}
