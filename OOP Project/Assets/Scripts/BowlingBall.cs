using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE. Bowling ball uses the EnableGravity from the BallMovement script in order to fall down.
public class BowlingBall : BallMovement
{


    //POLYMORPHISM. Bounciness from parent class (Ball Movement) is overriden.
    //The BOWLING BALL has a different level of bounciness.
    public override void StandardBouncy()
    {

        bouncy.material.bounciness = .1f;
        
    }


}
