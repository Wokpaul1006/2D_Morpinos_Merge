using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MorpinosSC : MonoBehaviour
{
    internal MergeSC mergeCtr;
    Vector3 mousePos;
    internal string morpinosName, morpinosStrait;
    internal int morpinosID;
    int delayWalk, prepairWalk;
    Vector3 curPos, targetPosAlly, minPos, maxPos;
    protected virtual void Start()
    {
        delayWalk = 100;
        prepairWalk = 0;
        mergeCtr = GameObject.Find("MergeMN").GetComponent<MergeSC>();
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
    internal void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }
}
