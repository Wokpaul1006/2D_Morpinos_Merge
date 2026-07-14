using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MorpinosSC : MonoBehaviour
{
    [SerializeField] GameObject poops;
    internal MergeSC mergeCtr;
    Vector3 mousePos;
    internal string morpinosName, morpinosStrait;
    internal int morpinosID;
    int delayWalk, prepairWalk;
    bool isAllowWalk;
    Vector3 curPos, targetToMove, minPos, maxPos;
    protected virtual void Start()
    {
        delayWalk = 100;
        prepairWalk = 0;
        isAllowWalk = true;
        mergeCtr = GameObject.Find("MergeMN").GetComponent<MergeSC>();
    }
    internal void Update()
    {
        prepairWalk++;
        if (prepairWalk >= delayWalk)
        {
            WalkAround();
            prepairWalk = 0;
        }
    }
    internal void MoveToPos()
    {
        transform.position = mousePos;
    }
    public void WalkAround()
    {
        if (isAllowWalk == true) 
        {
            curPos = gameObject.transform.position;

            minPos.x = -5;
            maxPos.x = 5;

            minPos.y = -3;
            minPos.y = 3;

            targetToMove.x = Random.Range(minPos.x, maxPos.x);
            targetToMove.y = Random.Range(minPos.y, maxPos.y);
            transform.DOMove(targetToMove, 0.5f);
            gameObject.transform.localScale = new Vector3(-gameObject.transform.localScale.x, gameObject.transform.localScale.y, 0);

            if(isRandPoop() >= 3)
            {
                Instantiate(poops, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
    internal void OnMouseDown()
    {
        isAllowWalk = false;
    }
    internal void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(mousePos.x, mousePos.y, transform.position.z);
    }
    internal void OnMouseUp() { isAllowWalk = true; }

    internal void DoAnim()
    {
        Vector3 originScale;
        originScale = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector3(originScale.x - (originScale.x*0.01f), originScale.y, 0); 
        if(prepairWalk >= 50f)
        {
            gameObject.transform.localScale = originScale;
        }
    }
    internal int isRandPoop()
    {
        return Random.Range(0, 10);
    }
}
