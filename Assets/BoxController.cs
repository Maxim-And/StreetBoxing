using UnityEngine;

public class BoxController : MonoBehaviour
{
    public float moveSpeed = 5f; // Bewegungsgeschwindigkeit

    private Animator animator; // Referenz auf den Animator

    void Start()
    {
        // Den Animator vom aktuellen GameObject abrufen
        animator = GetComponent<Animator>();

        // Sicherstellen, dass der Animator existiert
        if (animator == null)
        {
            Debug.LogError("Animator nicht gefunden! Bitte sicherstellen, dass ein Animator an diesem Objekt hängt.");
        }
    }

    void Update()
    {
        // Bewegung
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Schlag ausführen, wenn die Leertaste gedrückt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Punch();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            RightCross();
        }
    }

    void Punch()
    {
        Debug.Log("Schlag wird ausgeführt!");

        // Trigger "punch" im Animator setzen
        if (animator != null)
        {
            animator.SetTrigger("punch");
        }
    }

    void RightCross()
    {
        Debug.Log("Right Cross wird ausgeführt!");

        // Trigger "RightCross" im Animator setzen
        if (animator != null)
        {
            animator.SetTrigger("RightCross");
        }
    }

}
