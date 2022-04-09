using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour

{

    private float xPosition;
    private float zPosition;

    private float yLowPosition = 2;
    private float yMediumPosition = 4;
    private float yHighPosition = 6;

    public PhysicMaterial bounciness;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            LowButton();
        }

        if (Input.GetKeyDown("2"))
        {
            MediumButton();
        }

        if (Input.GetKeyDown("3"))
        {
            HighButton();
        }
    }

    void HighButton()
    {
        transform.Translate(xPosition, yHighPosition, zPosition);
    }

    void MediumButton()
    {
        transform.Translate(xPosition, yMediumPosition, zPosition);
    }

    void LowButton()
    {
        transform.Translate(xPosition, yLowPosition, zPosition);
    }

}
