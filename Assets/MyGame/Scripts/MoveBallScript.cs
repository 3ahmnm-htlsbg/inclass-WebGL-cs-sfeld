using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBallScript : MonoBehaviour
{
    public GameObject ball;
    [SerializeField] private GameObject[] ballPositions;

    private int GenerateNumber()
    {
        return Random.Range(0, 4);

    }

    public void PlaceBall()
    {
        int size;

        //check if the new postion is the same as the current one, if not place ball
        if (ball.transform.position != ballPositions[size = GenerateNumber()].transform.position)
        {
            Debug.Log(size);
            ball.transform.position = ballPositions[size].transform.position;
        }
        else
        {
            //Generate a new Number until it does not match the previous one and place the ball
            while (ball.transform.position == ballPositions[size].transform.position)
            {
                size = GenerateNumber();
            }
            ball.transform.position = ballPositions[size].transform.position;
        }
        
    }
        
}
