using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creepling01SC : MorpinosSC
{
    [SerializeField] GameObject nextStraitToSpawn;
    void Start()
    {
        morpinosStrait = "Creepling";
        morpinosID = 01;
        morpinosStrait = morpinosStrait+morpinosID.ToString();  
        base.Start();
    }
    private void Update()
    {
        base.Update();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == morpinosName)
        {
            Instantiate(nextStraitToSpawn, transform.position, Quaternion.identity);   
        }
    }
}
