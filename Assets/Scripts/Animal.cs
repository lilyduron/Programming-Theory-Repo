using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Rigidbody animalRb;
    protected float jumpForce;
    protected bool isOnGround;
    GameManager gameManager;
    private Animator animator;
    private float speed;

    // ENCAPSULATION
    private float a_PosX = -21;
    public float PosX
    {
      get { return a_PosX; } // getter returns backing field
      set { a_PosX = value; } // setter uses backing field
    }

    // ENCAPSULATION
    private float a_PosY = 0;
    public float PosY
    {
      get { return a_PosY; } // getter returns backing field
      set { a_PosY = value; } // setter uses backing field
    }
    
    // ENCAPSULATION
    private float a_PosZ = -2;
    public float PosZ
    {
      get { return a_PosZ; } // getter returns backing field
      set { a_PosZ = value; } // setter uses backing field
    }


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

    protected void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
          isOnGround=true;
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
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
      speed = 0;
      animator.SetFloat("Speed_f", speed);
    }

    public virtual float GetJumpForce()
    {
        return jumpForce;
    }
   
}

    
    
       
    



