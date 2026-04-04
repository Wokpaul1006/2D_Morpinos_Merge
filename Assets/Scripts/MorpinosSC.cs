using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorpinosSC : MonoBehaviour
{
    Vector3 mousePos;
    internal string morpinosName, morpinosStrait;
    internal int morpinosID;
    protected virtual void Start()
    {
        InvokeRepeating(nameof(GetPlayerPos), 0f, 1f);
    }
    internal void Update()
    {
        MoveToPos();
    }
    internal void MoveToPos()
    {
        print(" on move to pos");
        transform.position = mousePos;
    }
    internal void GetPlayerPos()
    {
        if (Input.GetMouseButtonDown(1))
        {
            print("in mouse pos collect");
            mousePos = Input.mousePosition;
        }
    }
}
