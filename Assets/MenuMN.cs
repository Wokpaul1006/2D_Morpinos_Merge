using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuMN : MonoBehaviour
{
    [SerializeField] List<GameObject> uiPanels = new List<GameObject>();
    [HideInInspector] DataSC dataCtr;

    [SerializeField] Text curMoney, curGems, curPower;
    [SerializeField] Text curSpawnBoost, curSpawnAmount;
    void Start()
    {
        HideAllPanels();
    }
    void HideAllPanels()
    {
        for (int i = 0; i < uiPanels.Count; i++)
        {
            uiPanels[i].gameObject.SetActive(false);
        }
    }
    void HidePanel(int panelOrder)
    {

    }
    void OnShowPanel(int panelOrder)
    {

    }
    void OnUpdateUI()
    {

    }
    public void OnGoesTogames(int value)
    {
        switch(value)
        {
            case 0:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.OrbitalFighter");
                break;
            case 1:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.TerraInAction");
                break;
            case 2:
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.AgeOfCkauz&");
                break;
        }
    }
}
