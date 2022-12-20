using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Variables
    public float horizontalInput;// left and right input
    public float speed = 10.0f;// how fast the player will move
    public float xRange = 20.0f; // how far the player can go on the x axis.


    public GameObject projectilePrefab;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange)// if the player goes to the edge of the screen they will stop and it will keep them in view.
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)// if the player goes to the edge of the screen they will stop and it will keep them in view.
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation); // Launch a projectile from the player
        }
    }
}
