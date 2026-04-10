using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Egg_CreepSC : MonoBehaviour
{
    int countToHatch;
    [SerializeField] int eggStraitTier;
    [SerializeField] GameObject creepling, arachiling, terrorling, megarhinos, primanos, gigantinos, terranos, drakinos;
    [SerializeField] Image hatchProgress;

    [HideInInspector] int eggStraitDNA;
    void Start()
    {
        countToHatch = 0;
        hatchProgress.fillAmount = 0;
    }
    private void OnMouseDown()
    {
        countToHatch++;
        if(eggStraitTier == 0)
        {
            //Creepling
            hatchProgress.fillAmount += 0.2f;
            if (countToHatch >= 5)
            {
                SpawnCreepling();
            }
        }else if(eggStraitTier == 1)
        {
            //Arachiling + Terrorling + Drakinos
            if (eggStraitDNA == 0)
            {
                //Arachiling
                SpawnAra();
            }else if (eggStraitDNA == 2)
            {
                //Terrorling
                SpawnTerror();
            }else if( eggStraitDNA == 3)
            {
                //Drakninos
                SpawnDraki();
            }
        }else if(eggStraitTier == 2)
        {
            //Megarhinos + Primanso
            if (eggStraitDNA == 4)
            {
                //Megarhinos
                SpawnMega();
            }
            else if (eggStraitDNA == 5)
            {
                //Primanos
                SpawnPrima();
            }
        } else if(eggStraitTier == 3)
        {
            //Terranos + Gigantinos
            if (eggStraitDNA == 6)
            {
                //Gigantinos
                SpawnGigant();
            }
            else if (eggStraitDNA == 7)
            {
                //Terranos
                SpawnTerra();
            }
        }

    }
    private void SpawnCreepling()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void SpawnAra()
    {
        Instantiate(arachiling, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void SpawnTerror()
    {
        Instantiate(terrorling, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void SpawnMega()
    {
        Instantiate(megarhinos, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void SpawnPrima()
    {
        Instantiate(primanos, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void SpawnGigant()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void SpawnTerra()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void SpawnDraki()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "OBJ_AraDNA") { eggStraitDNA = 0; }
        else if (collision.gameObject.name == "OBJ_AraDNA") { eggStraitDNA = 1; }
        else if (collision.gameObject.name == "OBJ_TerrorDNA") { eggStraitDNA = 2; }
        else if (collision.gameObject.name == "OBJ_DrakiDNA") { eggStraitDNA = 3; }
        else if (collision.gameObject.name == "OBJ_MegaDNA") { eggStraitDNA = 4; }
        else if (collision.gameObject.name == "OBJ_PrimaDNA") { eggStraitDNA = 5; }
        else if (collision.gameObject.name == "OBJ_GigantDNA") { eggStraitDNA = 6; }
        else if (collision.gameObject.name == "OBJ_TerraDNA") { eggStraitDNA = 7; }
    }
}
