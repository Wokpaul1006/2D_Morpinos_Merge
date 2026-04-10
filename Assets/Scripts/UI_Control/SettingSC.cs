using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingSC : MonoBehaviour
{
    [SerializeField] SoundSC soundMN;

    [SerializeField] Button soundTG, sfxToggle;
    void Start()
    {
        soundMN = GameObject.Find("GeneralControlMN").GetComponent<SoundSC>();   
    }

    public void OnToggleSound()
    {
        print("in toggle sound");
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
    public void ExitGame() => Application.Quit();
    public void ToPrivaciPolicy() { Application.OpenURL("https://sadekgame.wordpress.com/2026/03/18/privacy-policy-existium-age-of-ckauz/"); }
    public void ToTermUse() { Application.OpenURL("https://sadekgame.wordpress.com/2026/03/19/temr-use-existium-age-of-ckauz/"); }
    public void ToFB() { Application.OpenURL("https://www.facebook.com/sadeksoftVn"); }
    public void ToIG() { Application.OpenURL("https://www.instagram.com/sdsoftvn/"); }
    public void ToX() { Application.OpenURL("https://x.com/SadekGame15769"); }
    public void ToWebsite() { Application.OpenURL("https://play.google.com/store/apps/developer?id=Sadek+Games+Studio"); }
    public void ToYTB() { Application.OpenURL("https://www.youtube.com/@SadekGamesStudio"); }
    public void ToTikTok() { Application.OpenURL("https://www.tiktok.com/@sdsoft"); }
}
