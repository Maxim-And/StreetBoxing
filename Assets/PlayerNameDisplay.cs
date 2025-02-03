using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public Text player1NameText;//UI spieler 1
    public Text player2NameText;//UI spieler 2

    public string player1Name = "Player 1";//standard name 
    public string player2Name = "Player 2";

    void Start()
    {
        UpdateNames();
    }

    void UpdateNames()
    {
        player1NameText.text = player1Name;
        player2NameText.text = player2Name;
    }
}

