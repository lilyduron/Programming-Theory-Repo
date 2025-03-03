using UnityEngine;

public class Fox : Animal //INHERITANCE
{   
    // ENCAPSULATION
    [SerializeField] private float a_foxJumpForce = 7;
    public float foxJumpForce
    {
        get { return a_foxJumpForce; }
        set { a_foxJumpForce = value; }
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
        jumpForce = foxJumpForce;
        base.Jump();
    }

    //POLYMORPHISM
     public override float GetJumpForce()
    {
        return foxJumpForce;
    }
}
