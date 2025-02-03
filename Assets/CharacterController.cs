using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Animator animator; // Verweis auf den Animator

    void Update()
    {
        float move = Input.GetAxis("Horizontal"); // Bewegung in X-Richtung

        if (move != 0)
        {
            animator.SetBool("isWalking", true); // Setze die "isWalking"-Animation
        }
        else
        {
            animator.SetBool("isWalking", false); // Setze die "isWalking"-Animation auf false, wenn der Spieler steht
        }
    }
}
