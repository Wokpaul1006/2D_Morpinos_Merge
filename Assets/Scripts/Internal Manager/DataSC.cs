using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSC : MonoBehaviour
{
    [HideInInspector] PlayerInforSC infor;
    public string deviceID;
    public bool isFirstPlay;

    [SerializeField] SaveSystem saveSys;

    //Shared variables
    [HideInInspector] public int pSFX, pTheme;

    //Player's data variables

    [HideInInspector] public int pGems, pCoin; //actual in-game currency to buy things


    //Patrol & Achievemnt
    [HideInInspector] public int pAllowClaimDaily, pDailyStreak;
    [HideInInspector] public string pLastDailyClaim;

    //Morpinos Evolution Exclusive Vars
    [HideInInspector] public int pTotalScore; //total Morpinos was born, count on Creepling as base units
    [HideInInspector] public int pMorpinosOrder;

    [HideInInspector] public int pCreep0, pCreep1, pCreep2, pCreep3, pCreep4, pCreep5, pCreep6, pCreep7, pCreep8, pCreep9;
    [HideInInspector] public int pAra0, pAra1, pAra2, pAra3, pAra4;
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
        SettingStart();
    }
    public void Start()
    {
        MorpinosData dataLoad = saveSys.Load();
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
        PlayerPrefs.SetInt("TotalCoin", 0);

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
        pCoin = PlayerPrefs.GetInt("TotalCoin");
        pTheme = PlayerPrefs.GetInt("soundState");
        pSFX = PlayerPrefs.GetInt("sfxState");

        //Patrol Reward
        pLastDailyClaim = PlayerPrefs.GetString("LastPatrolDailyTime");
        pAllowClaimDaily = PlayerPrefs.GetInt("AllowClaimDaily");
        pDailyStreak = PlayerPrefs.GetInt("PatrolDailyStreak");

        //Gameplay
        OnLoadMorpinos();
    }
    private void OnLoadMorpinos()
    {
        
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

    //Economic
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
    public void UpdateTotalCoin(int coin)
    {
        PlayerPrefs.SetInt("TotalCoin", coin);
        pCoin = PlayerPrefs.GetInt("TotalCoin");
    }

    //Sound
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

    //Patrol Reward
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

    //Gameplay

    #endregion

    #region Update Morpinos
    public void OnUpdateCreepling(int breedOrder)
    {
        switch (breedOrder)
        {
            case 0:
                pCreep0 += 1;
                break;
            case 1:
                pCreep0 -= 2;
                pCreep1 += 1;
                break;
            case 2:
                pCreep1 -= 2;
                pCreep2 += 1;
                break;
            case 3:
                pCreep2 -= 2;
                pCreep3 += 1;
                break;
            case 4:
                pCreep3 -= 2;
                pCreep4 += 1;
                break;
            case 5:
                pCreep4 -= 2;
                pCreep5 += 1;
                break;
            case 6:
                pCreep5 -= 2;
                pCreep6 += 1;
                break;
            case 7:
                pCreep6 -= 2;
                pCreep7 += 1;
                break;
            case 8:
                pCreep7 -= 2;
                pCreep8 += 1;
                break;
            case 9:
                pCreep8 -= 2;
                pCreep9 += 1;
                break;
            case 10:
                pCreep9 -= 2;
                break;
        }
    }
    public void OnUpdateDataTier2(int breedOrder, int breedSubOrder)
    {
        if (breedOrder == 0)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pAra0 += 1;
                    break;
                case 1:
                    pAra0 -= 2;
                    pAra1 += 1;
                    break;
                case 2:
                    pAra1 -= 2;
                    pAra2 += 1;
                    break;
                case 3:
                    pAra2 -= 2;
                    pAra3 += 1;
                    break;
                case 4:
                    pAra3 -= 2;
                    pAra4 += 1;
                    break;
            }
        }
        else if (breedOrder == 1)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pTerror0 += 1;
                    break;
                case 1:
                    pTerror0 -= 2;
                    pTerror1 += 1;
                    break;
                case 2:
                    pTerror1 -= 2;
                    pTerror2 += 1;
                    break;
                case 3:
                    pTerror2 -= 2;
                    pTerror3 += 1;
                    break;
                case 4:
                    pTerror3 -= 2;
                    pTerror4 += 1;
                    break;
            }
        }
        else if (breedOrder == 2)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pDraki0 += 1;
                    break;
                case 1:
                    pDraki0 -= 2;
                    pDraki1 += 1;
                    break;
                case 2:
                    pDraki1 -= 2;
                    pDraki2 += 1;
                    break;
            }
        }
    }
    public void OnUpdateDataTier3(int breedOrder, int breedSubOrder)
    {
        if (breedOrder == 0)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pMega0 += 1;
                    break;
                case 1:
                    pMega0 -= 2;
                    pMega1 += 1;
                    break;
                case 2:
                    pMega1 -= 2;
                    pMega2 += 1;
                    break;
                case 3:
                    pMega2 -= 2;
                    pMega3 += 1;
                    break;
            }
        }
        else if (breedOrder == 1)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pPrima0 += 1;
                    break;
                case 1:
                    pPrima0 -= 2;
                    pPrima1 += 1;
                    break;
                case 2:
                    pPrima1 -= 2;
                    pPrima2 += 1;
                    break;
                case 3:
                    pPrima2 -= 2;
                    pPrima3 += 1;
                    break;
            }
        }
    }
    public void OnUpdateDataTier4(int breedOrder, int breedSubOrder)
    {
        if (breedOrder == 0)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pGigan0 += 1;
                    break;
                case 1:
                    pGigan0 -= 2;
                    pGigan1 += 1;
                    break;
                case 2:
                    pGigan1 -= 2;
                    pGigan2 += 1;
                    break;
            }
        }
        else if (breedOrder == 1)
        {
            switch (breedSubOrder)
            {
                case 0:
                    pTerra0 += 1;
                    break;
                case 1:
                    pTerra0 -= 2;
                    pTerra1 += 1;
                    break;
                case 2:
                    pTerra1 -= 2;
                    pTerra2 += 1;
                    break;
            }
        }
    }
    #endregion

    #region Checking Zone
    private bool CheckFirstPlay()
    {
        //print("FirstPlay: " + PlayerPrefs.GetInt("HasPlayed"));
        if (PlayerPrefs.GetInt("HasPlayed") == 1) return isFirstPlay = false;
        else return true;
    }
    #endregion

    #region Save to JSON
    public void AutoSaveMorpinos()
    {
        SaveCreep();
        SaveAra();
        SaveTerror();
        SavePrima();
        SaveMega();
        SaveGigant();
        SaveTerra();
        SaveDraki();
    }
    private void SaveCreep()
    {
        int[] a = { pCreep0, pCreep1, pCreep2, pCreep3, pCreep4, pCreep5, pCreep6, pCreep7, pCreep8, pCreep9 };
        saveSys.OnSaveCreep(a);
    }
    private void SaveAra() 
    {
        int[] a = { pAra0, pAra1, pAra2, pAra3, pAra4 };
        saveSys.OnSaveAra(a);
    }
    private void SaveTerror()
    {
        int[] a = { pTerror0, pTerror1, pTerror2, pTerror3, pTerror4 };
        saveSys.OnSaveTerror(a);
    }
    private void SaveMega()
    {
        int[] a = {pMega0, pMega1, pMega2, pMega3 };
        saveSys.OnSaveMega(a);
    }
    private void SavePrima()
    {
        int[] a = { pPrima0, pPrima1, pPrima2, pPrima3 };
        saveSys.OnSavePrima(a);
    }
    private void SaveGigant()
    {
        int[] a = { pGigan0, pGigan1, pGigan2 };
        saveSys.OnSaveGigant(a);
    }
    private void SaveTerra()
    {
        int[] a = { pTerra0, pTerra1, pTerra2 };
        saveSys.OnSaveTerra(a);
    }
    private void SaveDraki()
    {
        int[] a = { pDraki0, pDraki1, pDraki2 };
        saveSys.OnSaveDraki(a);
    }
    #endregion
}
