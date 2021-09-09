using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{   
    //Global variables
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use AWSD or Arrow keys to move your player");
        Debug.Log("Don't hit the walls!");


    }

    void MovePlayer()
    {
        //define variables
        float xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;;
        float zValue = Input.GetAxis("Vertical")  * moveSpeed * Time.deltaTime;;
        
        //move player
        transform.Translate(xValue, 0, zValue);
    }
}
