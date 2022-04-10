using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    public Vector3 bowlingBallPosition;
    public Vector3 basketBallPosition;
    public Vector3 tennisBallPosition;

    public GameObject bowlingBall;
    public GameObject basketBall;
    public GameObject tennisBall;

    //private BallMovement ballMovement;





    void Start()
    {
        bowlingBallPosition = new Vector3(-4, 7.7f, -3);
        basketBallPosition = new Vector3(1.5f, 7.7f, -3);
        tennisBallPosition = new Vector3(6.6f, 7.7f, -3);


        //ballMovement = GameObject.Find("Bowling Ball").GetComponent<BallMovement>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            BallDrop();
            //ballMovement.StandardBouncy();
        }

        if (Input.GetKeyDown("2"))
        {
            RemoveAllBalls();
        }
    }

    void RemoveAllBalls()
    {
        GameObject[] destroyBalls;
        destroyBalls = GameObject.FindGameObjectsWithTag("balltag");
        foreach (GameObject bowlingBall in destroyBalls) Destroy(bowlingBall);
    }


    void BallDrop()
    {
        

        Instantiate(ballPrefabs[0], bowlingBallPosition, Quaternion.identity);
        Instantiate(ballPrefabs[1], basketBallPosition, Quaternion.identity);
        Instantiate(ballPrefabs[2], tennisBallPosition, Quaternion.identity);


    }
}
