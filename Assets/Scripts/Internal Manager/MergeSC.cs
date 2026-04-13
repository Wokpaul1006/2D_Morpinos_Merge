using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSC : MonoBehaviour
{
    [HideInInspector] GenControlSC genCtr;

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
        InvokeRepeating(nameof(SpawnEggCreepling), 0f, 5f);
        pairedCount = 0;
    }
    private void SpawnEggCreepling()
    {
        int tempPosX, tempPosY;
        tempPosX = Random.Range(-5, 5);
        tempPosY = Random.Range(-3, 3);
        spawnPos = new Vector3(tempPosX, tempPosY, 0);
        Instantiate((prefEggCreep[0]), spawnPos, Quaternion.identity);
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
