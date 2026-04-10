using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSC : Singleton<SoundSC>
{
    [SerializeField] AudioSource theme;
    [SerializeField] List<AudioClip> audioClips = new List<AudioClip>();
    [HideInInspector] DataSC data;

    private int themeMode, sfxMode;
    public bool isAllowSFX, isAllowTheme;
    private void Awake()
    {
        data = GameObject.Find("GeneralControlMN").GetComponent<DataSC>();
    }
    private void Start()
    {
        //GetSoundInfor();

        int randTheme;
        randTheme = Random.Range(0, 3);
        theme.clip = audioClips[randTheme];

        PlayTheme();

        if (isAllowTheme == true) PlayTheme();
        else if (isAllowTheme == false) MuteTheme();

        if (isAllowSFX == true) PlaySFX();
        else if (isAllowSFX == false) MuteSFX();
    }

    private void GetSoundInfor()
    {
        themeMode = PlayerPrefs.GetInt("soundState");
        sfxMode = PlayerPrefs.GetInt("sfxState");

        if (themeMode == 0) isAllowTheme = false;
        else if (themeMode == 1) isAllowTheme = true;

        if (sfxMode == 0) isAllowSFX = false;
        else if (sfxMode == 1) isAllowSFX = true;
    }

    public void PlayTheme()
    {
        theme.Play();
        theme.volume = 1;
        isAllowTheme = true;
        themeMode = 1;
        data.UpdateThemeState(themeMode);


    }
    public void MuteTheme()
    {
        theme.Pause();
        theme.volume = 0;
        isAllowTheme = false;
        themeMode = 0;
        data.UpdateThemeState(themeMode);
    }
    public void PlaySFX()
    {
        isAllowSFX = true;
        sfxMode = 1;
        data.UpdateSFXState(sfxMode);
    }
    public void MuteSFX()
    {
        isAllowSFX = false;
        sfxMode = 0;
        data.UpdateSFXState(sfxMode);
    }
    public void OnAjustTheme() => theme.volume = 0.25f;
}
