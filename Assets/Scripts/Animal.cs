using UnityEngine;

public class Animal : MonoBehaviour
{
    Rigidbody playerRb;
    public float jumpForce= 10;
    public bool isOnGround;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       //ABSTRACTION 
       Jump();     
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
          isOnGround=true;
        }
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
         {
           playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
           isOnGround = false;
         }
    }
}

    
    
       
    



