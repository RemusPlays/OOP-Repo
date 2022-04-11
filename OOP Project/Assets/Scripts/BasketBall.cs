using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBall : BallMovement
{
    public override void StandardBouncy()
    {

        bouncy.material.bounciness = .9f;

    }
}
