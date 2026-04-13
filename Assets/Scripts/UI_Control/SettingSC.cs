using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingSC : MonoBehaviour
{
    [SerializeField] SoundSC soundMN;
    [SerializeField] GameObject creditPnl, inforPnl;
    [SerializeField] Button soundTG, sfxToggle;
    void Start()
    {
        soundMN = GameObject.Find("GenMN").GetComponent<SoundSC>();   
    }

    public void OnToggleSound()
    {
        if (soundMN.isAllowTheme == true)
        {
            soundMN.MuteTheme();
        }
        else if(soundMN.isAllowTheme == false)
        {
            soundMN.PlayTheme();
        } 
    }
    public void OnToggleSFX()
    {
        if (soundMN.isAllowSFX == true)
        {
            soundMN.MuteSFX();
        }
        else if(soundMN.isAllowSFX == false)
        {
            soundMN.PlaySFX();
        }
    }
    public void ToCredits()
    {
        creditPnl.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
    public void ToInfors()
    {
        inforPnl.gameObject.SetActive(true);
        gameObject.SetActive(false );
    }
    public void ExitGame() => Application.Quit();
}
