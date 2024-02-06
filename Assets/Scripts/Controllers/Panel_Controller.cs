using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Controller : MonoBehaviour
{
    [SerializeField] private CanvasGroup c_Group;
    [SerializeField] private GameObject gameOver_Screen;

    private void Start()
    {
        EndGame_Manager.endGame_Manager.RegisterPanelController(this);
    }


    public void Activate_GameOver_Screen()
    {
        c_Group.alpha = 1;
        gameOver_Screen.SetActive(true);
    }
}
