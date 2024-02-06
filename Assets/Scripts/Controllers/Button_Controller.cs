using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Button_Controller : MonoBehaviour
{
    public void ResetLevel()
    {
        Fade_canvas.fader.FaderLoader_Int(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadLevelByString(string level_String)
    {
        Fade_canvas.fader.FaderLoader_String(level_String);
    }
}
