using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WikisSC : MonoBehaviour
{
    private string specieURL, planetURL;
    private string eggyURL, creepURL, araURL, terrorURL, megaURL, primaURL, drakiURL, gigantURL, terraURL;
    private string hivemindURL, essenseSphereURL, nuclepinosURL;
    void Start()
    {
        AssistLinks();
    }
    public void ToWikies(int a)
    {
        switch (a)
        {
            case 0:
                //Morpinos Specie
                Application.OpenURL(specieURL);
                break;
            case 1:
                //Planet
                Application.OpenURL(planetURL);
                break;
            case 2:
                Application.OpenURL(eggyURL);
                break;
            case 3:
                Application.OpenURL(creepURL);
                break;
            case 4:
                Application.OpenURL(araURL);
                break;
            case 5:
                Application.OpenURL(terrorURL);
                break;
            case 6:
                Application.OpenURL(drakiURL);
                break;
            case 7:
                //Morpinos Specie
                Application.OpenURL(megaURL);
                break;
            case 8:
                //Planet
                Application.OpenURL(primaURL);
                break;
            case 9:
                Application.OpenURL(terraURL);
                break;
            case 10:
                Application.OpenURL(gigantURL);
                break;
            case 11:
                Application.OpenURL(hivemindURL);
                break;
            case 12:
                Application.OpenURL(essenseSphereURL);
                break;
            case 13:
                Application.OpenURL(nuclepinosURL);
                break;
        }
    }
    private void AssistLinks()
    {
        planetURL = "https://sadekgame.wordpress.com/2025/09/22/lore-planet-magnar/";
        specieURL = "https://sadekgame.wordpress.com/2025/02/27/morpinos/";
        eggyURL = "https://sadekgame.wordpress.com/2026/04/06/unit-eggy-existium-universe/";
        creepURL = "https://sadekgame.wordpress.com/2024/08/16/creepling/";
        araURL = "https://sadekgame.wordpress.com/2024/08/16/armored-arachiling/";
        terrorURL = "https://sadekgame.wordpress.com/2026/01/19/unit-terrorling-morpinos-existium-wiki/";
        megaURL = "https://sadekgame.wordpress.com/2024/08/16/megarhino/";
        primaURL = "https://sadekgame.wordpress.com/2024/08/16/knucleape/\r\n";
        drakiURL = "https://sadekgame.wordpress.com/2024/08/16/dinoflakk/";
        gigantURL = "https://sadekgame.wordpress.com/2026/04/06/unit-gigantinos-existium-universe/\r\n";
        terraURL = "https://sadekgame.wordpress.com/2026/04/06/unit-terrainos-existium-universe/";
        hivemindURL = "https://sadekgame.wordpress.com/2026/01/19/struct-overhive-ipm-existium-codex/";
        essenseSphereURL = "https://sadekgame.wordpress.com/2025/10/31/wiki-struct-essence-well-2/";
        nuclepinosURL = "https://sadekgame.wordpress.com/2026/04/14/struct-nuclepinos-existium-wiki/";
    }
}
