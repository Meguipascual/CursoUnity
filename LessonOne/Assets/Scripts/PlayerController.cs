using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20.0f;
    private float turnSpeed= 45.0f;
    private float horizontalInput;
    private float verticallInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get the player inputs
        horizontalInput = Input.GetAxis("Horizontal");
        verticallInput = Input.GetAxis("Vertical");

        //Moves the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * verticallInput * speed);
        //Rotates the vehicle based on horizontal input
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput );
        
    }
}
