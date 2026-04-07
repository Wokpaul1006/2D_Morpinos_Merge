using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSC : MonoBehaviour
{
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
    [SerializeField] GameObject prefEggCreep;
    private Vector3 spawnPos;
    int pairedCount;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEggCreepling), 0f, 5f);
        pairedCount = 0;
    }
    private void SpawnEggCreepling()
    {
        int tempPosX, tempPosY;
        tempPosX = Random.Range(-7, 7);
        tempPosY = Random.Range(-4, 4);
        spawnPos = new Vector3(tempPosX, tempPosY, 0);
        Instantiate((prefEggCreep), spawnPos, Quaternion.identity);
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
                    Instantiate(creeplingToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(araToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(terrorToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(drakiToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(megaToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(primaToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(terraToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(gigantToSpawn[objectToSpawn], spawnPos, Quaternion.identity);
                    break;
            }
        }
    }
}
