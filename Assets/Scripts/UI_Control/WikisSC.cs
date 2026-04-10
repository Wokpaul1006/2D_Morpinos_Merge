using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WikisSC : MonoBehaviour
{
    void Start()
    {

    }
    public void OnClose()
    {

    }
    public void ToWikies(int a)
    {
        switch (a)
        {
            case 0:
                //Orx Specie
                Application.OpenURL("https://sadekgame.wordpress.com/2025/09/22/lore-specie-orcinian/");
                break;
            case 1:
                //Orx Green
                Application.OpenURL("https://sadekgame.wordpress.com/2025/09/22/lore-specie-orcinian/");
                break;
            case 2:
                //Orx Red
                Application.OpenURL("https://sadekgame.wordpress.com/2025/09/22/lore-specie-orcinian/");
                break;
            case 3:
                //Orx Ebony
                Application.OpenURL("https://sadekgame.wordpress.com/2025/09/22/lore-specie-orcinian/");
                break;
            case 4:
                //Orx Pale
                Application.OpenURL("https://sadekgame.wordpress.com/2025/09/22/lore-specie-orcinian/");
                break;
            case 5:
                //Morpinos
                Application.OpenURL("https://sadekgame.wordpress.com/2025/02/27/morpinos/");
                break;
            case 6:
                //The Scourge Horde
                Application.OpenURL("https://sadekgame.wordpress.com/2025/08/19/lore-the-scourge-horde/");
                break;
        }
    }
}
