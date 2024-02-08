using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin_Controller : MonoBehaviour
{
    private void Start()
    {
        TextMeshProUGUI coin_TMP = GetComponent<TextMeshProUGUI>();
        EndGame_Manager.endGame_Manager.Register_Coin_Text(coin_TMP);
        coin_TMP.text = "Coin: 0";
    }

}
