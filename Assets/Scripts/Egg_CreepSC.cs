using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderKeywordFilter;
using UnityEngine;
using UnityEngine.UI;

public class Egg_CreepSC : MonoBehaviour
{
    int countToHatch;
    [SerializeField] GameObject creepling;
    [SerializeField] Image hatchProgress;
    void Start()
    {
        countToHatch = 0;
        hatchProgress.fillAmount = 0;
    }
    private void OnMouseDown()
    {
        countToHatch++;
        hatchProgress.fillAmount += 0.2f;
        if(countToHatch >= 5)
        {
            SpawnCreepling();
        }
    }
    private void SpawnCreepling()
    {
        Instantiate(creepling, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
