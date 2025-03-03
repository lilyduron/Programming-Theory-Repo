using UnityEngine;

public class Moose : Animal  //INHERITANCE
{ 
    // ENCAPSULATION
    [SerializeField] private float a_mooseJumpForce = 8;
    public float mooseJumpForce
    {
        get { return a_mooseJumpForce; }
        set { a_mooseJumpForce = value; }
    }
    
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
        jumpForce = mooseJumpForce;
        base.Jump();
    }

    //POLYMORPHISM
     public override float GetJumpForce()
    {
        return mooseJumpForce;
    }
}
