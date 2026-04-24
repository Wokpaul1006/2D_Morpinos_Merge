using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenControlSC : MonoBehaviour
{
    [HideInInspector] public string today;
    int curPower; //Total power of player, depend on Creepling was spawned on screen
    [SerializeField] DataSC dataCtr;
    [SerializeField] SettingSC settingCtr;
    [SerializeField] PlayerInforSC inforCtr;
    [SerializeField] CreditSC credtCr;
    [SerializeField] SceneSC sceneCtr;

    [HideInInspector] MenuMN menuCtr;
    [HideInInspector] ConquerSC conquerCtr;
    void Start()
    {
        today = (DateTime.Today.Day).ToString();
        curPower = dataCtr.pTotalScore;
        OnShowSetting(false);
        OnShowCredits(false);
        OnShowInfor(false);
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
}
