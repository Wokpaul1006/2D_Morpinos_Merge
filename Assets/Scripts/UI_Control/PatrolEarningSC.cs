using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PatrolEarningSC : MonoBehaviour
{
    [HideInInspector] DataSC data;
    [HideInInspector] GenControlSC genCtr;

    [SerializeField] List<Button> rewardBtn = new List<Button>();
    [SerializeField] List<GameObject> dailyGrid = new List<GameObject>();
    [SerializeField] List<Text> rewardText = new List<Text>();
 
    private const string LastPatrolTimeKey = "LastPatrolTime";
    private const string PatrolStreakKey = "PatrolStreak";
    private int baseReward = 10; // example reward, x2 for each time count
    public int rewardToGive;
    private bool isAllowDailyClaim;
    private int streakDaily;
    private string lastCollectDay;
    void Start()
    {
        genCtr = GameObject.Find("GeneralControlMN").GetComponent<GenControlSC>();
        data = GameObject.Find("GeneralControlMN").GetComponent<DataSC>();

        isAllowDailyClaim = false;
        streakDaily = data.pDailyStreak;
        lastCollectDay = "";
        rewardToGive = 0;
        OverrideUI();
        ShowRewardDaily();
    }

    private void OverrideUI()
    {
        rewardText[0].text = "10";
        rewardText[1].text = "20";
        rewardText[2].text = "40";
        rewardText[3].text = "80";
        rewardText[4].text = "160";
        rewardText[5].text = "320";
        rewardText[6].text = "640";
        rewardText[7].text = "1280";
    }

    #region Handle Claim Daily
    void ShowRewardDaily()
    {
        if (genCtr.today != data.pLastDailyClaim)
        {
            //New day access
            rewardBtn[streakDaily+1].GetComponent<Button>().interactable = true;
            if (streakDaily >= 1 && streakDaily < 8)
            {
                //Lock previous day claim buttons
                for (int i = 0; i <= streakDaily - 1; i++)
                {
                    rewardBtn[i].GetComponent<Button>().interactable = false;
                }
                isAllowDailyClaim = true;
            }
        }
        else if (genCtr.today == data.pLastDailyClaim)
        {
            //Same day access
            isAllowDailyClaim = false;
            rewardBtn[streakDaily].GetComponent<Button>().interactable = false;
        }
    }
    public void OnClaimDaily()
    {
        int tempFinalScoreToOverride;
        SelectRewardDaily();
        tempFinalScoreToOverride = baseReward + data.pTotalScore;

        print("streakDaily = " + streakDaily);

        rewardBtn[streakDaily].GetComponent<Button>().interactable = false;
        streakDaily++;

        lastCollectDay = DateTime.Today.Day.ToString();

        isAllowDailyClaim = false;

        data.UpdateTotalScore(tempFinalScoreToOverride); // Update score
        data.UpdateStreak(1, streakDaily); //Update streak
        data.UpdatePatrolDailyReward(lastCollectDay); //Update last collect day

        //ShowRewardDaily();
        //menu.UpdateUI();
    }
    private void SelectRewardDaily()
    {
        switch (streakDaily)
        {
            case 0:
                baseReward = 10;
                break;
            case 1:
                baseReward = 20;
                break;
            case 2:
                baseReward = 40;
                break;
            case 3:
                baseReward = 80;
                break;
            case 4:
                baseReward = 160;
                break;
            case 5:
                baseReward = 320;
                break;
            case 6:
                baseReward = 640;
                break;
            case 7:
                baseReward = 1280;
                break;
        }
    }
    #endregion
}
