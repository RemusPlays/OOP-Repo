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

    private BallMovement bowlingBallMovement;
    private BallMovement basketBallMovement;
    private BallMovement tennisBallMovement;

 



    void Start()
    {
        bowlingBallPosition = new Vector3(-4, 7.7f, -3);
        basketBallPosition = new Vector3(1.5f, 7.7f, -3);
        tennisBallPosition = new Vector3(6.6f, 7.7f, -3);
    }

    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            BallSpawn();
            Debug.Log("1, BallSpawn has been pressed");
            
        }

        if (Input.GetKeyDown("2"))
        {
            RemoveAllBalls();
            Debug.Log("2, RemoveAllBalls has been pressed");
        }


        if (Input.GetKeyDown("3"))
        {
            BallDrop();
            Debug.Log("3, BallDrop has been pressed");
        }
    }

    void BallSpawn()
    {
        if (GameObject.Find("Bowling Ball(Clone)") == null && GameObject.Find("Basket Ball(Clone)") == null && GameObject.Find("Tennis Ball(Clone)") == null)
        {
            Instantiate(ballPrefabs[0], bowlingBallPosition, Quaternion.identity);
            Instantiate(ballPrefabs[1], basketBallPosition, Quaternion.identity);
            Instantiate(ballPrefabs[2], tennisBallPosition, Quaternion.identity);
        }


    }

    void RemoveAllBalls()
    {
        GameObject[] destroyBalls;
        destroyBalls = GameObject.FindGameObjectsWithTag("balltag");
        foreach (GameObject bowlingBall in destroyBalls) Destroy(bowlingBall);
    }


    
    //ABSTRACTION. This Function deploys multiple functions, which are to clearly 1) enable gravity and 2)Add bounce to the objects. 
    void BallDrop()
    {
        
        bowlingBallMovement = GameObject.Find("Bowling Ball(Clone)").GetComponent<BallMovement>();
        bowlingBallMovement.EnableGravity();
        bowlingBallMovement.StandardBouncy();               

        basketBallMovement = GameObject.Find("Basket Ball(Clone)").GetComponent<BallMovement>();
        basketBallMovement.EnableGravity();
        basketBallMovement.StandardBouncy();

        tennisBallMovement = GameObject.Find("Tennis Ball(Clone)").GetComponent<BallMovement>();
        tennisBallMovement.EnableGravity();
        tennisBallMovement.StandardBouncy();

    }
}
