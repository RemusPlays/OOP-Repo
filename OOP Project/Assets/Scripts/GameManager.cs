using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private Vector3 bowlingBallPosition;
    private Vector3 basketBallPosition;
    private Vector3 tennisBallPosition;

    private BallMovement bowlingBallMovement;
    private BallMovement basketBallMovement;
    private BallMovement tennisBallMovement;


    void Start()
    {
        basketBallPosition = new Vector3(-4, 7.7f, -3);
        bowlingBallPosition = new Vector3(1.5f, 7.7f, -3);       
        tennisBallPosition = new Vector3(6.6f, 7.7f, -3);
    }
    

    public void BallSpawn()
    {
        if (GameObject.Find("Bowling Ball(Clone)") == null && GameObject.Find("Basket Ball(Clone)") == null && GameObject.Find("Tennis Ball(Clone)") == null)
        {
            Instantiate(ballPrefabs[0], bowlingBallPosition, Quaternion.identity);
            Instantiate(ballPrefabs[1], basketBallPosition, Quaternion.identity);
            Instantiate(ballPrefabs[2], tennisBallPosition, Quaternion.identity);
        }

    }

    //ABSTRACTION. This Function deploys multiple functions, which are to clearly 1) enable gravity and 2)Add bounce to the objects. 
    public void BallDrop()
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

    public void DisableGravity()
    {
        bowlingBallMovement.DisableGravity();
        basketBallMovement.DisableGravity();
        tennisBallMovement.DisableGravity();
    }

    public void RemoveAllBalls()
    {
        GameObject[] destroyBalls;
        destroyBalls = GameObject.FindGameObjectsWithTag("balltag");
        foreach (GameObject bowlingBall in destroyBalls) Destroy(bowlingBall);
    }

    public void BackButton()
    {
        SceneManager.LoadScene(1);
    }

}
