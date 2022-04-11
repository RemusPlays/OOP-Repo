using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE. Basket ball uses the EnableGravity from the BallMovement script in order to fall down.
public class BasketBall : BallMovement
{


    //POLYMORPHISM. Bounciness from parent class (Ball Movement) is overriden.
    //The BASKET BALL has a different level of bounciness.
    public override void StandardBouncy()
    {

        bouncy.material.bounciness = .9f;

    }
}
