using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSC : MonoBehaviour
{
    [SerializeField] MergeSC mergeCtr;
    private void Start()
    {
        mergeCtr = GameObject.Find("MergeMN").GetComponent<MergeSC>();
    }
    private void OnMouseDown()
    {
        OnCountReward();
    }
    void OnCountReward()
    {
        if(ChanceToGiveDiamond() >= 7)
        {
            mergeCtr.IncreaseCurDiamond(1);
        }else if(ChanceToGiveDiamond() < 7)
        {
            mergeCtr.IncreaseCurCoin(10);
        }
        Destroy(gameObject);
    }
    private int ChanceToGiveDiamond()
    {
        return Random.Range(0, 10);
    }
}
