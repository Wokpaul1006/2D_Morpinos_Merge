using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSC : MonoBehaviour
{
    [HideInInspector] GenControlSC genCtr;
    [HideInInspector] DataSC dataSC;

    [SerializeField] List<GameObject> creeplingToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> araToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> terrorToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> drakiToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> megaToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> primaToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> terraToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> gigantToSpawn = new List<GameObject>();
    //
    [SerializeField] List<GameObject> prefEggCreep = new List<GameObject>();
    //
    [SerializeField] GameObject essensePool;
    private Vector3 spawnPos;
    int pairedCount, curPower;
    void Start()
    {
        genCtr = GameObject.Find("GenMN").GetComponent<GenControlSC>();
        dataSC = GameObject.Find("GenMN").GetComponent<DataSC>();
        InvokeRepeating(nameof(SpawnEggCreepling), 0f, 5f);
        pairedCount = 0;

        SpawnOnInit();
    }
    private void SpawnEggCreepling()
    {
        int tempPosX, tempPosY;
        tempPosX = Random.Range(-5, 5);
        tempPosY = Random.Range(-3, 3);
        spawnPos = new Vector3(tempPosX, tempPosY, 0);
        Instantiate((prefEggCreep[0]), spawnPos, Quaternion.identity);
    }
    private void SpawnOnInit()
    {
        if(dataSC.pCreep0 != 0) { Instantiate(creeplingToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep1 != 0) { Instantiate(creeplingToSpawn[1], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep2 != 0) { Instantiate(creeplingToSpawn[2], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep3 != 0) { Instantiate(creeplingToSpawn[3], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep4 != 0) { Instantiate(creeplingToSpawn[4], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep5 != 0) { Instantiate(creeplingToSpawn[5], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep6 != 0) { Instantiate(creeplingToSpawn[6], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep7 != 0) { Instantiate(creeplingToSpawn[7], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep8 != 0) { Instantiate(creeplingToSpawn[8], Vector3.zero, Quaternion.identity); }
        if (dataSC.pCreep9 != 0) { Instantiate(creeplingToSpawn[9], Vector3.zero, Quaternion.identity); }

        if (dataSC.pAra0 != 0) { Instantiate(araToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pAra1 != 0) { Instantiate(araToSpawn[1], Vector3.zero, Quaternion.identity); }
        if (dataSC.pAra2 != 0) { Instantiate(araToSpawn[2], Vector3.zero, Quaternion.identity); }
        if (dataSC.pAra3 != 0) { Instantiate(araToSpawn[3], Vector3.zero, Quaternion.identity); }
        if (dataSC.pAra4 != 0) { Instantiate(araToSpawn[4], Vector3.zero, Quaternion.identity); }

        if (dataSC.pTerror0 != 0) { Instantiate(terrorToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pTerror1 != 0) { Instantiate(terrorToSpawn[1], Vector3.zero, Quaternion.identity); }
        if (dataSC.pTerror2 != 0) { Instantiate(terrorToSpawn[2], Vector3.zero, Quaternion.identity); }
        if (dataSC.pTerror3 != 0) { Instantiate(terrorToSpawn[3], Vector3.zero, Quaternion.identity); }
        if (dataSC.pTerror4 != 0) { Instantiate(terrorToSpawn[4], Vector3.zero, Quaternion.identity); }

        if (dataSC.pDraki0 != 0) { Instantiate(drakiToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pDraki1 != 0) { Instantiate(drakiToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pDraki2 != 0) { Instantiate(drakiToSpawn[0], Vector3.zero, Quaternion.identity); }

        if (dataSC.pMega0 != 0) { Instantiate(megaToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pMega1 != 0) { Instantiate(megaToSpawn[1], Vector3.zero, Quaternion.identity); }
        if (dataSC.pMega2 != 0) { Instantiate(megaToSpawn[2], Vector3.zero, Quaternion.identity); }
        if (dataSC.pMega3 != 0) { Instantiate(megaToSpawn[3], Vector3.zero, Quaternion.identity); }

        if (dataSC.pPrima0 != 0) { Instantiate(primaToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pPrima1 != 0) { Instantiate(primaToSpawn[1], Vector3.zero, Quaternion.identity); }
        if (dataSC.pPrima2 != 0) { Instantiate(primaToSpawn[2], Vector3.zero, Quaternion.identity); }
        if (dataSC.pPrima3 != 0) { Instantiate(primaToSpawn[3], Vector3.zero, Quaternion.identity); }

        if (dataSC.pGigan0 != 0) { Instantiate(gigantToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pGigan0 != 1) { Instantiate(gigantToSpawn[1], Vector3.zero, Quaternion.identity); }
        if (dataSC.pGigan0 != 2) { Instantiate(gigantToSpawn[2], Vector3.zero, Quaternion.identity); }

        if (dataSC.pTerra0 != 0) { Instantiate(terraToSpawn[0], Vector3.zero, Quaternion.identity); }
        if (dataSC.pTerra1 != 0) { Instantiate(terraToSpawn[1], Vector3.zero, Quaternion.identity); }
        if (dataSC.pTerra2 != 0) { Instantiate(terraToSpawn[2], Vector3.zero, Quaternion.identity); }
    }
    public void OnCallSpawn(int breedOrder, int objectToSpawn, float posX, float posY)
    {
        pairedCount++;
        Vector3 spawnPos = new Vector3(posX, posY, 0);
        if(pairedCount >= 2)
        {
            pairedCount = 0;
            switch (breedOrder)
            {
                case 0:
                    //Creepling
                    if(objectToSpawn >= 10)
                    {
                        Instantiate(prefEggCreep[1], spawnPos, Quaternion.identity);
                    }
                    else { Instantiate(creeplingToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity); }
                    break;
                case 1:
                    //Ara
                    if (objectToSpawn >= 5)
                    {
                        Instantiate(prefEggCreep[2], spawnPos, Quaternion.identity);
                    }else                    Instantiate(araToSpawn[objectToSpawn+1], spawnPos, Quaternion.identity);
                    break;
                case 2:
                    //Terroling
                    if (objectToSpawn >= 5)
                    {
                        Instantiate(prefEggCreep[2], spawnPos, Quaternion.identity);
                    }else                    Instantiate(terrorToSpawn[objectToSpawn+1], spawnPos, Quaternion.identity);
                    break;
                case 3:
                    //Drakinos
                    if (objectToSpawn <= 2)
                    {
                        Instantiate(drakiToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                    }
                    break;
                case 4:
                    if (objectToSpawn >= 4)
                    {
                        Instantiate(prefEggCreep[3], spawnPos, Quaternion.identity);
                    }else                    Instantiate(megaToSpawn[objectToSpawn+1], spawnPos, Quaternion.identity);
                    break;
                case 5:
                    if (objectToSpawn >= 4)
                    {
                        Instantiate(prefEggCreep[3], spawnPos, Quaternion.identity);
                    }else                    Instantiate(primaToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                    break;
                case 6:
                    if (objectToSpawn >= 3)
                    {
                        Instantiate(essensePool, spawnPos, Quaternion.identity);
                    }else                     Instantiate(terraToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                    break;
                case 7:
                    if (objectToSpawn >= 3)
                    {
                        Instantiate(essensePool, spawnPos, Quaternion.identity);
                    }else                    Instantiate(gigantToSpawn[objectToSpawn + 1], spawnPos, Quaternion.identity);
                    break;
            }
        }
    }
    public void OnCountCurrentPower()
    {
        genCtr.IncreaseCurPower();
    }
}
