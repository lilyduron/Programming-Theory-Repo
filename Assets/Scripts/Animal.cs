using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Rigidbody animalRb;
    [SerializeField] protected float jumpForce;
    protected bool isOnGround;
    GameManager gameManager;
    private Animator animator;
    private float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       animalRb = GetComponent<Rigidbody>();
       gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
       animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       //ABSTRACTION 
       Jump();     
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
          isOnGround=true;
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
          //Debug.Log("Hit a rock");
          gameManager.GameOver();
          StopAnimal();
        }
    }

    public virtual void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
         {
           animalRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           isOnGround = false;
         }
    }

    public void StopAnimal()
    {
      speed= 0;
      animator.SetFloat("Speed_f", speed);
    }

   
}

    
    
       
    



