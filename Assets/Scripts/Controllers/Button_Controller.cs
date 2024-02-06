using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button_Controller : MonoBehaviour
{
    public void ResetLevel()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Fade_canvas.fader.FaderLoader_Int(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1;
    }
    public void LoadLevelByString(string level_String)
    {
        Fade_canvas.fader.FaderLoader_String(level_String);
    }
}
