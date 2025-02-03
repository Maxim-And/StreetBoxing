using UnityEngine;
using UnityEngine.UI;

public class RoundManager : MonoBehaviour
{
    public Text roundText;  // UI-Element für die Runde
    public int currentRound = 1;  // Start in Runde 1

    void Start()
    {
        UpdateRoundText();  // Initiale Anzeige
    }

    public void NextRound()
    {
        currentRound++;  // Runde erhöhen
        UpdateRoundText();
    }

    void UpdateRoundText()
    {
        roundText.text = "Round " + currentRound;  // Text aktualisieren
    }
}