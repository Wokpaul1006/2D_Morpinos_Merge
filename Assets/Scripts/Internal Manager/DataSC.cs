using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSC : MonoBehaviour
{
    [HideInInspector] PlayerInforSC infor;
    public string deviceID;
    public bool isFirstPlay;

    //Shared variables
    [HideInInspector] public int pSFX, pTheme;

    //Player's data variables

    [HideInInspector] public int pGems, pCoin; //actual in-game currency to buy things


    //Patrol & Achievemnt
    [HideInInspector] public int pAllowClaimDaily, pDailyStreak;
    [HideInInspector] public string pLastDailyClaim;

    //Morpinos Evolution Exclusive Vars
    [HideInInspector] public int pTotalScore; //total Morpinos was born, count on Creepling as base units
    [HideInInspector] public int pCreep0, pCreep1, pCreep2, pCreep3, pCreep4, pCreep6, pCreep7, pCreep8, pCreep9;
    [HideInInspector] public int pAra0, pAra1, pAra2, pAra3, pAra4S;
    [HideInInspector] public int pTerror0, pTerror1, pTerror2, pTerror3, pTerror4;
    [HideInInspector] public int pDraki0, pDraki1, pDraki2;
    [HideInInspector] public int pMega0, pMega1, pMega2, pMega3;
    [HideInInspector] public int pPrima0, pPrima1, pPrima2, pPrima3;
    [HideInInspector] public int pTerra0, pTerra1, pTerra2;
    [HideInInspector] public int pGigan0, pGigan1, pGigan2;
    [HideInInspector] public int pStructHive, pStructEssensePool, pSructMoneyMine;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        //PlayerPrefs.DeleteAll();
        SettingStart();
    }

    #region Local Handle
    private void SettingStart()
    {
        deviceID = SystemInfo.deviceUniqueIdentifier;
        if (CheckFirstPlay() == true)
        {
            SetNewPlayer();
        }
        else if (CheckFirstPlay() == false)
        {
            LoadOldPlayer();
        }
        ///infor = GameObject.Find("GenMN").GetComponent<PlayerInforSC>();
    }

    #endregion

    #region Player Data Handle
    private void SetNewPlayer()
    {
        Debug.Log("in new layer");
        PlayerPrefs.SetInt("HasPlayed", 1);

        PlayerPrefs.SetInt("Highscore", 0); //For total overview, leaderboard
        PlayerPrefs.SetInt("Totalscore", 0); //Actual player in-game currency
        PlayerPrefs.SetInt("TotalGems", 0); //Player's PIA currency

        PlayerPrefs.SetInt("soundState", 1);
        PlayerPrefs.SetInt("sfxState", 1);

        //Patrol Reward
        PlayerPrefs.SetInt("AllowClaimDaily", 0);
        PlayerPrefs.SetString("LastPatrolDailyTime", "");
        PlayerPrefs.SetInt("PatrolDailyStreak", 0);

        //Gameplay
        PlayerPrefs.SetInt("TotalBattleFight", 0);
        PlayerPrefs.SetInt("TotalBattleWin", 0);
        PlayerPrefs.SetInt("LongestMatch", 0);
        PlayerPrefs.SetInt("HigestArcadeWave", 0);
        PlayerPrefs.SetInt("HighestUnitBought", 0);
        PlayerPrefs.SetInt("HighestEnemyKilled", 0);

        PlayerPrefs.SetString("ClanName", "");
        PlayerPrefs.SetInt("CurrentStoryLevel", 0);

        PlayerPrefs.SetInt("GreenPlayTime", 0);
        PlayerPrefs.SetInt("RedPlayTime", 0);
        PlayerPrefs.SetInt("PalePlayTime", 0);
        PlayerPrefs.SetInt("EbonyPlayTime", 0);

        Invoke("LoadOldPlayer", 3f); //De tam thoi
    }
    private void LoadOldPlayer()
    {
        pTotalScore = PlayerPrefs.GetInt("Totalscore");
        pGems = PlayerPrefs.GetInt("TotalGems");
        pTheme = PlayerPrefs.GetInt("soundState");
        pSFX = PlayerPrefs.GetInt("sfxState");

        //Patrol Reward
        pLastDailyClaim = PlayerPrefs.GetString("LastPatrolDailyTime");
        pAllowClaimDaily = PlayerPrefs.GetInt("AllowClaimDaily");
        pDailyStreak = PlayerPrefs.GetInt("PatrolDailyStreak");

        //Gameplay
    }
    public void DataDelete()
    {
        PlayerPrefs.DeleteAll();
        SetNewPlayer();
        //infor.GetPlayerData();
    }
    public void UploadPlayerData()
    {
        //Sent core data to Server
    }
    #endregion

    #region Data Update
    public void UpdateTotalScore(int currencyToPlus)
    {
        int tempTotalScore;
        tempTotalScore = pTotalScore + currencyToPlus;
        PlayerPrefs.SetInt("Totalscore", tempTotalScore);
        pTotalScore = PlayerPrefs.GetInt("Totalscore");
    }
    public void UpdateTotalGem(int gems)
    {
        PlayerPrefs.SetInt("TotalGems", gems);
        pGems = PlayerPrefs.GetInt("TotalGems");
    }
    public void UpdateSFXState(int sfxState)
    {
        PlayerPrefs.SetInt("sfxState", sfxState);
        pSFX = PlayerPrefs.GetInt("sfxState");
    }
    public void UpdateThemeState(int thameState)
    {
        PlayerPrefs.SetInt("soundState", thameState);
        pTheme = PlayerPrefs.GetInt("soundState");
    }
    public void UpdatePatrolDailyReward(string lastPatrolDaily)
    {
        PlayerPrefs.SetString("LastPatrolDailyTime", lastPatrolDaily);
        pLastDailyClaim = PlayerPrefs.GetString("LastPatrolDailyTime");
    }
    public void UpdateAllowClaimDaily(int state)
    {
        PlayerPrefs.SetInt("AllowClaimDaily", state);
        pAllowClaimDaily = PlayerPrefs.GetInt("AllowClaimAllowClaimDaily");
    }
    public void UpdateStreak(int typeStreak, int value)
    {
        PlayerPrefs.SetInt("PatrolDailyStreak", value);
        pDailyStreak = PlayerPrefs.GetInt("PatrolDailyStreak");
    }
    #endregion

    #region Update Morpinos
    
    #endregion

    #region Checking Zone
    private bool CheckFirstPlay()
    {
        //print("FirstPlay: " + PlayerPrefs.GetInt("HasPlayed"));
        if (PlayerPrefs.GetInt("HasPlayed") == 1)
        {
            return isFirstPlay = false;
        }
        else return true;
    }
    #endregion
}
