using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creep09SC : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Creep";
        morpinosID = 9;
        morpinosName = morpinosStrait + morpinosID.ToString();
        base.Start();
    }
    private void Update()
    {
        base.Update();
    }
    internal void OnTriggerEnter2D(Collider2D collision)
    {
        string colName = collision.gameObject.GetComponent<Creepling01SC>().morpinosName;
        if (colName == morpinosName)
        {
            Destroy(collision.gameObject);
            Instantiate(nextStraitToSpawn, transform.position, Quaternion.identity);
        }
    }
}
