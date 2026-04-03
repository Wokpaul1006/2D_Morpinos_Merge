using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeSC : MonoBehaviour
{
    [SerializeField] GameObject prefEggCreep;
    private Vector3 spawnPos;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEggCreepling), 0f, 5f);
    }
    private void SpawnEggCreepling()
    {
        int tempPosX, tempPosY;
        tempPosX = Random.Range(-7, 7);
        tempPosY = Random.Range(-4, 4);
        spawnPos = new Vector3(tempPosX, tempPosY, 0);
        Instantiate((prefEggCreep), spawnPos, Quaternion.identity);
    }
}
