using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed=30;

    private float leftBound= -15;


    // Update is called once per frame
    void Update()
    { 
       //ABSTRACTION 
       Move();
    }

    void Move()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    
}
