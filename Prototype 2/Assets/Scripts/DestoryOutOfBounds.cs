using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{
    #region Variables
    private float topBound = 30;
    private float lowerBound = -10;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If an object goes past the players view in the game, remove that object
        if(transform.position.z > topBound)//destroys the pizza and animals when they pass the stated position
        {
            Destroy(gameObject);
        } 
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
