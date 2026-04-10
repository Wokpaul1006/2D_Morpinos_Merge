using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSC : Singleton<SceneSC>
{
    private void Start() { }
    public void LoadScene(int sceneOder)
    {
        switch (sceneOder)
        {
            case 0:
                SceneManager.LoadScene("00_LoadScene");
                break;
            case 1:
                SceneManager.LoadScene("01_MainScene");
                break;
            case 2:
                SceneManager.LoadScene("02_ConquerScene");
                break;
        }
    }
}
