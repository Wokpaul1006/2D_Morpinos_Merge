using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInforSC : MonoBehaviour
{
    [SerializeField] Text pName, pTotalBattle, pTotalMoney, pClanName, pStoryLevel;
    [HideInInspector] DataSC data;
    private void Awake()
    {
        data = GameObject.Find("GeneralControlMN").GetComponent<DataSC>();
    }
    private void OnEnable()
    {
        pTotalMoney.text = data.pTotalScore.ToString();
    }
}
