using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndMenu_Manager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI score_TextMeshPro;
    [SerializeField] private TextMeshProUGUI highScore_TextMeshPro;
    [SerializeField] private TextMeshProUGUI coin_TextMeshPro;

    private int coin_Prefab;
    private int highScore_Prefab;
    private int score_Prefab;

    private void Awake()
    {
        highScore_Prefab = PlayerPrefs.GetInt("High_ScoreGamePlay", 0);
    }

    public void Display_HighScore_EndMenu()
    {
        //highScore_TextMeshPro.text = highScore_Prefab.ToString();
    }


    public void Register_HighScore_Text_EndMenu(TextMeshProUGUI highScore_TMP)
    {
        highScore_TextMeshPro = highScore_TMP;
    }


    /*   public void Set_Score()
       {
           PlayerPrefs.SetInt("Score" + SceneManager.GetActiveScene().name, Score);
           int highScore = PlayerPrefs.GetInt("High_Score" + SceneManager.GetActiveScene().name, 0);

           if (Score > highScore)
           {
               PlayerPrefs.SetInt("High_Score" + SceneManager.GetActiveScene().name, Score);
           }
           Score = 0;
       }*/
}
