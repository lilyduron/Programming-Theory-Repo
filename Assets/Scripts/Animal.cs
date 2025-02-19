using UnityEngine;

public class Animal : MonoBehaviour
{
    protected Rigidbody animalRb;
    [SerializeField] protected float jumpForce;
    protected bool isOnGround;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       animalRb = GetComponent<Rigidbody>();
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
    }

    public virtual void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
         {
           animalRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           isOnGround = false;
         }
    }
}

    
    
       
    



