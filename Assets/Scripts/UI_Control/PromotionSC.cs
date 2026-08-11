using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromotionSC : MonoBehaviour
{
    public void OnToGames(int index)
    {
        switch (index)
        {
            case 0:
                //Asrtal Knight
                Application.OpenURL("https://play.google.com/store/apps/dev?id=8768446082102228101");
                break;
            case 1:
                //Orbital Fighter
                Application.OpenURL("https://play.google.com/store/apps/dev?id=8768446082102228101e");
                break;
            case 2:
                //Orx War
                Application.OpenURL("https://play.google.com/store/apps/dev?id=8768446082102228101");
                break;
            case 3:
                //Morpinos Conquerer
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.OrxWar&pcampaignid=web_share");
                break;
            case 4: 
                //Krakois Wars
                Application.OpenURL("https://play.google.com/store/apps/details?id=com.SDSoft.MorpinosConquering&pcampaignid=web_share");
                break;
        }
    }
}
