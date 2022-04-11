using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//INHERITANCE. Tennis ball uses the EnableGravity from the BallMovement script in order to fall down.
public class TennisBall : BallMovement
{
    private float m_TennisBallBounciness = .1f;
    public float TennisBallBounciness
    {
        get { return m_TennisBallBounciness; }
        set
        {
            if (value < 0.2f)
            {
                Debug.LogError("You cannot do this stop right now");

            }
            else
            {
                m_TennisBallBounciness = value;
            }
        }
    }

    //POLYMORPHISM. Bounciness from parent class (Ball Movement) is overriden.
    //The TENNIS BALL has a different level of bounciness.
    public override void StandardBouncy()
    {

        bouncy.material.bounciness = TennisBallBounciness;

    }

  
}
