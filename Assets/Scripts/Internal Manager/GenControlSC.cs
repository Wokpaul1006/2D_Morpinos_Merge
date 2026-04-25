using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenControlSC : MonoBehaviour
{
    [HideInInspector] public string today;
    [HideInInspector] MenuMN menuCtr;
    [HideInInspector] ConquerSC conquerCtr;

    [SerializeField] DataSC dataCtr;
    [SerializeField] SettingSC settingCtr;
    [SerializeField] PlayerInforSC inforCtr;
    [SerializeField] CreditSC credtCr;
    [SerializeField] SceneSC sceneCtr;

    public bool isBoostAmount, isBoostRate, isBoostCoin;
    int countdownSpawnRate, countdownSpawnAmount, countdownCoinValueBoost;
    int curPower; //Total power of player, depend on Creepling was spawned on screen

    void Start()
    {
        today = (DateTime.Today.Day).ToString();
        curPower = dataCtr.pTotalScore;
        OnShowSetting(false);
        OnShowCredits(false);
        OnShowInfor(false);
        CheckBoostingEffect();
    }

    public void IncreaseCurPower()
    {
        dataCtr.UpdateTotalScore(1);
        curPower = dataCtr.pTotalScore;
        menuCtr.OnUpdateCurPowerUI(curPower);
    }
    public void OnAssistElements(int sceneOrder)
    {
        if (sceneOrder == 1)
        {
            Invoke(nameof(AssistMenuCtr), 1f);
        }else if(sceneOrder == 2)
        {
            Invoke(nameof(AssistConquerCtr), 1f);
        }
    }
    private void AssistMenuCtr() 
    {
        menuCtr = GameObject.Find("CAN_MainCan").GetComponent<MenuMN>();
        menuCtr.OnUpdateCurPowerUI(curPower);
    }
    private void AssistConquerCtr()
    {
        conquerCtr = GameObject.Find("ConquerMN").GetComponent<ConquerSC>(); 
    }
    public void OnShowSetting(bool isShow) => settingCtr.gameObject.SetActive(isShow);
    public void OnShowInfor(bool isShow) => inforCtr.gameObject.SetActive(isShow);
    public void OnShowCredits(bool isShow) => credtCr.gameObject.SetActive(isShow);
    public void OnGoesToHatchery() => sceneCtr.LoadScene(1);
    public void OnGoesToConquer() => sceneCtr.LoadScene(2);
    
    public void UpdateMenuUI()
    {
        menuCtr.OnUpdateUI();
    }
    private void CheckBoostingEffect()
    {
        countdownSpawnRate = dataCtr.pEggBonusRate;
        countdownSpawnAmount = dataCtr.pEggBonusAmount;
        countdownCoinValueBoost = dataCtr.pCoinBonusVaue;

        if (countdownSpawnRate > 0)
        {
            InvokeRepeating(nameof(OnCountDownSpawnRate), 0f, 1f);
            isBoostRate = true;
        }
        else isBoostRate = false;

        if (countdownSpawnAmount > 0)
        {
            InvokeRepeating(nameof(OnCountDownSpawnAmount), 0f, 1f);
            isBoostAmount = true;
        }
        else isBoostAmount = false;

        if (countdownCoinValueBoost > 0)
        {
            InvokeRepeating(nameof(OnCountdownCoinValue), 0f, 1f);
            isBoostCoin = true;
        }
        else isBoostCoin = false;
    }
    private void OnCountDownSpawnRate()
    {
        countdownSpawnRate--;
        dataCtr.UpdateBonusSpawnRate(countdownSpawnRate);
        if (countdownSpawnRate <= 0) isBoostRate = false;
        CancelInvoke(nameof(OnCountDownSpawnRate));
    }
    private void OnCountDownSpawnAmount()
    {
        countdownSpawnAmount--;
        dataCtr.UpdateBonusSpawnRate(countdownSpawnAmount);
        if (countdownSpawnAmount <= 0) isBoostAmount = false;
        CancelInvoke(nameof(OnCountDownSpawnAmount));
    }
    private void OnCountdownCoinValue()
    {
        countdownCoinValueBoost--;
        dataCtr.UpdateBonusSpawnRate(countdownCoinValueBoost);
        if (countdownCoinValueBoost <= 0) isBoostCoin = false;
        CancelInvoke(nameof(OnCountdownCoinValue));
    }
}
