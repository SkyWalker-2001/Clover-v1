using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Info_List_Display: MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI highscore_TMP;
    [SerializeField] private TextMeshProUGUI score_TMP;
    [SerializeField] private TextMeshProUGUI coin_TMP;

    private int coin_Prefab;
    private int highScore_Prefab;
    private int score_Prefab;

    private void OnEnable()
    {
        highScore_Prefab = PlayerPrefs.GetInt("High_ScoreGamePlay", 0);
        highscore_TMP.text = "HighScore: " + highScore_Prefab.ToString();
        
        score_Prefab = PlayerPrefs.GetInt("ScoreGamePlay", 0);
        score_TMP.text = "Score: " + score_Prefab.ToString();
        
        coin_Prefab = PlayerPrefs.GetInt("TotalCoinGamePlay", 0);
        coin_TMP.text = "Coin: " + coin_Prefab.ToString();
    }
}
