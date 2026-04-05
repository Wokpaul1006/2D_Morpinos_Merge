using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorpinosSC : MonoBehaviour
{
    Vector3 mousePos;
    internal string morpinosName, morpinosStrait;
    internal int morpinosID;
    int delayWalk, prepairWalk;
    Vector3 curPos, targetPosAlly, minPos, maxPos, idlePos;
    protected virtual void Start()
    {
        delayWalk = 100;
        prepairWalk = 0;
        InvokeRepeating(nameof(WalkAround), 1f, 2f);
    }
    internal void Update()
    {
        prepairWalk++;
        if (prepairWalk >= delayWalk)
        {
            prepairWalk = 0;
            WalkAround();
        }
    }
    internal void MoveToPos()
    {
        transform.position = mousePos;
    }
    public void WalkAround()
    {
        curPos = gameObject.transform.position;
        targetPosAlly.x = Random.Range(minPos.x, maxPos.x);
        targetPosAlly.y = Random.Range(minPos.y - 1, maxPos.y + 1);
        gameObject.transform.position = targetPosAlly;
    }
    internal void OnMouseDown()
    {

    }
    internal void OnMouseDrag()
    {
        print("in draging");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        print("mouse pos = " + mousePos);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }
}
