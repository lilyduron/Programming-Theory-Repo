using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 25;

    [SerializeField] private float leftBound= -40;

    GameManager gameManager;


    void Start()
    {  
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        
    }


    // Update is called once per frame
    void Update()
    { 
       //ABSTRACTION 
       Move();
    }

    void Move()
    {
        if(gameManager.isGameActive == true)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

        
        
    }
    
}
