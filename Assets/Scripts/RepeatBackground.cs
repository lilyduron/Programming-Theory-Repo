using System;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    //the start position of the background
    private Vector3 startPos;
    // variable to calculate the point to repeat the background
    private float repeatWidth;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         //ABSTRACTION
        CalculateRepeatWidth();
    }

    // Update is called once per frame
    void Update()
    {
        //ABSTRACTION
        Repeat();
    }

    void Repeat()
    {
       if(transform.position.x < startPos.x - repeatWidth)
        {
           transform.position = startPos;
        }
    }

    //calculate the middle point to repeat the background
    void CalculateRepeatWidth()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }
}
