using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE. Tennis ball uses the EnableGravity from the BallMovement script in order to fall down.
public class TennisBall : BallMovement
{
    private float TennisBallBounciness = 1f;
   

    //POLYMORPHISM. Bounciness from parent class (Ball Movement) is overriden.
    //The TENNIS BALL has a different level of bounciness.
    public override void StandardBouncy()
    {

        bouncy.material.bounciness = TennisBallBounciness;

    }

  
}
