using UnityEngine;

public class Stag : Animal  //INHERITANCE
{
    // ENCAPSULATION
    [SerializeField] private float a_stagJumpForce = 9;
    public float stagJumpForce
    {
        get { return a_stagJumpForce; }
        set { a_stagJumpForce = value; }
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
        jumpForce = stagJumpForce;
        base.Jump();
    }
    
    //POLYMORPHISM
    public override float GetJumpForce()
    {
        return stagJumpForce;
    }
}
