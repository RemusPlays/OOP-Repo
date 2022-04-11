using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour

{


    public Collider bouncy;
    public Rigidbody ballRb;
    
    void Start()
    {
        bouncy = GetComponent<SphereCollider>();
        ballRb = GetComponent<Rigidbody>();

 
    }

    void Update()
    {

    }

    public void EnableGravity()
    {
        ballRb.useGravity = true;
    }


    public virtual void StandardBouncy()
    {
        bouncy.material.bounciness = 1;
        
    }




}
