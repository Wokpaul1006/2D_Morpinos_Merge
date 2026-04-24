using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSC : MonoBehaviour
{
    [HideInInspector] DataSC dataCtr;
    int priceBoost, priceAmoubt, priceBoostCoin, priceEgg01, priceEgg02, priceEgg03, priceEg00;
    void Start()
    {
        dataCtr = GameObject.Find("GenMN").GetComponent<DataSC>();
        priceBoost = 100;
        priceAmoubt = 100;
        priceBoostCoin = 100;
    }

    public void OnBuyBoostAmount()
    {
        if(IsAllowBuy(dataCtr.pCoin, priceBoost))
        {
            //Allow Boost amoun
        }
    }
    public void OnBuyBoostRate()
    {

    }
    public void OnBuyBoostCoin()
    {

    }
    public void OnBuyEgg(int eggOrder)
    {

    }
    private bool IsAllowBuy(int curMoney, int itemPrice)
    {
        if(curMoney >= itemPrice)
        {
            return true;
        }else return false;
    }
}
