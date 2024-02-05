using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame_Manager : MonoBehaviour
{
    public static EndGame_Manager endGame_Manager;

    private Player_State player;


    public bool gameOver;


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
        yield return new WaitForSeconds(2.5f);
        ResolveGame();
    }
    public void ResolveGame()
    {
        if (gameOver == false)
        {
            Win_Game();
        }

       /* else if (gameOver == true)
        {
            Ad_Lose_Game();
        }*/

        else if (gameOver == true)
        {
            Lose_Game();
        }
    }

    public void Win_Game()
    {
        Debug.Log("sd");
    }
    
   /* public void Ad_Lose_Game()
    {
        Debug.Log("sd");

    }*/

    public void Lose_Game()
    {
        Debug.Log("sd");

    }


    public void RegisterPlayerState(Player_State player_State)
    {
        player = player_State;
    }
}
