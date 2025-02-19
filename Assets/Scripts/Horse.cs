using UnityEngine;

public class Horse : Animal  //INHERITANCE
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animalRb= GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
         Jump();  
    }

    //POLYMORPHISM
    public override void Jump()
    {
        jumpForce = 8;
        base.Jump();
    }
}
