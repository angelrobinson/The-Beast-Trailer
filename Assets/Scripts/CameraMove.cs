using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform startMarker;
    public Transform endMarker;
    public Transform lookTarget;
    
    public float speed = 1.0F;
    public float turnSpeed = 20.0f;
    private float startTime;
    private float journeyLength;
    int index;

    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(-speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Turn(-turnSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Turn(turnSpeed);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            gameObject.transform.position += new Vector3(0, .1f);

        }
    }

    public void Move(float speed)
    {
        
        Vector3 forwardSpeed = gameObject.transform.forward * speed;

       
        gameObject.GetComponent<CharacterController>().SimpleMove(forwardSpeed);
    }

    //rotate controller left or right
    public void Turn(float turnSpeed)
    {
        
        Vector3 rotationSpeed = Vector3.up * turnSpeed * Time.deltaTime;

        
        gameObject.transform.Rotate(rotationSpeed, Space.Self);

    }

}
