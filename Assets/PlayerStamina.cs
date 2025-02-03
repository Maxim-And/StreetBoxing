using UnityEngine;
using UnityEngine.UI;

public class PlayerStamina : MonoBehaviour
{
    public Slider staminaSlider;  // Der StaminaSlider
    public float maxStamina = 100f;  // Maximale Ausdauer
    private float currentStamina;  // Aktuelle Ausdauer
    private float staminaRegenerationRate = 5f;  // Wie schnell sich die Ausdauer regeneriert
    private float staminaUsageRate = 20f;  // Wie viel Ausdauer pro Aktion verbraucht wird

    private bool isPunching = false;  // Flag, das überprüft, ob der Spieler gerade schlägt
    private bool isDodging = false;  // Flag, das überprüft, ob der Spieler ausweicht

    void Start()
    {
        currentStamina = maxStamina;  // Setze die aktuelle Ausdauer auf die maximale Ausdauer
        staminaSlider.maxValue = maxStamina;  // Setze den Maximalwert des Sliders auf die maximale Ausdauer
        staminaSlider.value = currentStamina;  // Setze den aktuellen Wert des Sliders auf die aktuelle Ausdauer
    }

    void Update()
    {
        // Beispiel: Wenn der Spieler schlägt (mit Leertaste)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isPunching = true;
            UseStamina(staminaUsageRate);  // Verbrauche Ausdauer beim Schlagen
        }

        // Beispiel: Wenn der Spieler ausweicht (mit Shift-Taste)
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDodging = true;
            UseStamina(staminaUsageRate);  // Verbrauche Ausdauer beim Ausweichen
        }

        // Regeneriere Ausdauer, wenn der Spieler nicht schlägt oder ausweicht
        if (!isPunching && !isDodging)
        {
            RegenerateStamina(staminaRegenerationRate * Time.deltaTime);  // Regeneriere Ausdauer
        }
    }

    public void UseStamina(float amount)
    {
        currentStamina -= amount;  // Ziehe Ausdauer ab
        if (currentStamina < 0)  // Verhindern, dass Ausdauer unter 0 fällt
        {
            currentStamina = 0;
        }
        staminaSlider.value = currentStamina;  // Setze den Slider-Wert auf die neue Ausdauer
    }

    public void RegenerateStamina(float amount)
    {
        currentStamina += amount;  // Regeneriere Ausdauer
        if (currentStamina > maxStamina)  // Verhindern, dass Ausdauer über das Maximum geht
        {
            currentStamina = maxStamina;
        }
        staminaSlider.value = currentStamina;  // Setze den Slider-Wert auf die neue Ausdauer
    }
}
