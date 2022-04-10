using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour

{


    public Collider bouncy;
    
    void Start()
    {
        bouncy = GetComponent<SphereCollider>();
    }

    void Update()
    {

    }

    public virtual void StandardBouncy()
    {
        bouncy.material.bounciness = 1f;
    }




}
