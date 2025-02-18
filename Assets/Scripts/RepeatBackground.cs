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
        startPos = transform.position;
        // we add a box collider to the background, we get the size and divide by 2 to get the exact half point of the background
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPos.x - repeatWidth)
        {
           transform.position = startPos;
        }
    }
}
