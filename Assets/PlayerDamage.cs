using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public CanvasGroup headHealthBar; // Referenz für HeadHealthBar
    public CanvasGroup bodyHealthBar; // Referenz für BodyHealthBar

    void Start()
    {
        // Beide Lebensbalken zu Beginn unsichtbar
        headHealthBar.alpha = 0f;
        bodyHealthBar.alpha = 0f;
    }

    void Update()
    {
        // Beispiel: Schaden am Kopf
        if (Input.GetKeyDown(KeyCode.K)) // Drücke "K" für Kopf-Schaden
        {
            ShowHeadHealthBar();
        }

        // Beispiel: Schaden am Körper
        if (Input.GetKeyDown(KeyCode.B)) // Drücke "B" für Körper-Schaden
        {
            ShowBodyHealthBar();
        }
    }

    void ShowHeadHealthBar()
    {
        // Kopf-Lebensbalken sichtbar machen
        headHealthBar.alpha = 1f;

        // Kopf-Lebensbalken nach 2 Sekunden wieder unsichtbar machen
        Invoke("HideHeadHealthBar", 2f);
    }

    void ShowBodyHealthBar()
    {
        // Körper-Lebensbalken sichtbar machen
        bodyHealthBar.alpha = 1f;

        // Körper-Lebensbalken nach 2 Sekunden wieder unsichtbar machen
        Invoke("HideBodyHealthBar", 2f);
    }

    void HideHeadHealthBar()
    {
        // Kopf-Lebensbalken wieder unsichtbar machen
        headHealthBar.alpha = 0f;
    }

    void HideBodyHealthBar()
    {
        // Körper-Lebensbalken wieder unsichtbar machen
        bodyHealthBar.alpha = 0f;
    }
}
