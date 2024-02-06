using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score_Controller : MonoBehaviour
{
    public int score_Multiplayer;
    private void Start()
    {
        TextMeshProUGUI textForResistration = GetComponent<TextMeshProUGUI>();
        EndGame_Manager.endGame_Manager.Register_Score_Text(textForResistration);
        textForResistration.text = "Score: 0";
    }

    private void FixedUpdate()
    {
        EndGame_Manager.endGame_Manager.UpdateScore(score_Multiplayer);
    }
}
