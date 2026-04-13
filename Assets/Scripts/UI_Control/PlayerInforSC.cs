using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInforSC : MonoBehaviour
{
    [SerializeField] Text pName, pStrenght, pPlanetConquer, pMoney, pGems;
    [HideInInspector] DataSC data;
    private void Awake()
    {
        data = GameObject.Find("GenMN").GetComponent<DataSC>();
    }
    private void OnEnable()
    {
        pName.text = "Morpinos Swarm";
        pStrenght.text = data.pTotalScore.ToString();
        pPlanetConquer.text = 0.ToString();
        pMoney.text = data.pCoin.ToString();
        pGems.text = data.pGems.ToString();
    }
}
