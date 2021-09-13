using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 20;
    public float turnSpeed;
    public float horizontalInput;
    //public float verticallInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle forward
        horizontalInput = Input.GetAxis("Horizontal");
        //verticallInput = Input.GetAxis("Vertical");
        //transform.Translate(Vector3.forward * Time.deltaTime * verticallInput * speed);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);//*speed
    }
}
