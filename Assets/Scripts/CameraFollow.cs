using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//PURPOSE: Camera Will Follow Player in a flowy kind of movement 
//USAGE: attatch this to an empty game object with a collider that is set as is trigger 

// rework this to be smooth like platformer project

public class CameraFollow : MonoBehaviour
{
    Transform cameraFocusTarget; // 

    void OnTriggerEnter2D(Collider2D activator)
    {
        cameraFocusTarget = activator.transform; // grab the placement of the camera
    }// Update is called once per frame
    void Update()
    {
        if (cameraFocusTarget != null)
        {
            Vector3 moveVector = cameraFocusTarget.position - Camera.main.transform.position;
            if (moveVector.magnitude > 2f)
            {
                moveVector = moveVector.normalized;
            }
            moveVector.z = 0f;
            Camera.main.transform.position += moveVector * Time.deltaTime * 20f;
        }

    }


    //public Transform target;

    /*private void LateUpdate()
    {
        if (target.position.y > transform.position.y) 
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
    */
}
