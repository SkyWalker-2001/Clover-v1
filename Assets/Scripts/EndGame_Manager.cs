using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame_Manager : MonoBehaviour
{
    public static EndGame_Manager endGame_Manager;

    private Player_State player;
    private Panel_Controller panel_Controller;
    private TextMeshProUGUI scoreTextMeshPro;

    public bool gameOver;

    public int Score;

    private void Awake()
    {
        if (endGame_Manager == null)
        {
            endGame_Manager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {

    }

    public void StartResolveSequence()
    {
        StopCoroutine(nameof(ResolveSequence));
        StartCoroutine(ResolveSequence());
    }

    private IEnumerator ResolveSequence()
    {
        yield return new WaitForSeconds(.1f);
        ResolveGame();
    }
    public void ResolveGame()
    {
        if (gameOver == false)
        {
            Debug.Log("WIN");
        }

        else if (gameOver == true)
        {
            Lose_Game();
        }
    }

    public void Lose_Game()
    {
        Set_Score();

        panel_Controller.Activate_GameOver_Screen();

        Time.timeScale = 0;
    }

    public void UpdateScore(int addScore)
    {
        Score += addScore;
        Debug.Log($"{Score} score");
        scoreTextMeshPro.text = "Score: " + Score.ToString();
    }

    public void Set_Score()
    {
        PlayerPrefs.SetInt("Score" + SceneManager.GetActiveScene().name, Score);
        int highScore = PlayerPrefs.GetInt("High_Score" + SceneManager.GetActiveScene().name, 0);

        if (Score > highScore)
        {
            PlayerPrefs.SetInt("High_Score" + SceneManager.GetActiveScene().name, Score);
        }
        Score = 0;
    }

    public void RegisterPlayerState(Player_State player_State)
    {
        player = player_State;
    }


    public void RegisterPanelController(Panel_Controller pC)
    {
        panel_Controller = pC;
    }

    public void Register_Score_Text(TextMeshProUGUI score_TMP)
    {
        scoreTextMeshPro = score_TMP;
    }
}
