using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlingBall : BallMovement
{





    public override void StandardBouncy()
    {
        //base.StandardBouncy();
        bouncy.material.bounciness = 0;
    }


}
