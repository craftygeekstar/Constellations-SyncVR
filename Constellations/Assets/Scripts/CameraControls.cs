using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    /*
        This script controls the camera movement using mouse movements.
    */

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    public int minH = -90;
    public int maxH = 90;

    private float pitch = 0.0f;
    public int minV = -90;
    public int maxV = 90;

    public PlayerControls pc;


    void Update()
    {
        if (pc.isPaused)
        {
            //if paused, stop camera movement.
            return;
        }

        else
        {
            //lock mouse cursor to the centre of the game screen
            Cursor.lockState = CursorLockMode.Locked;

            yaw += speedH * Input.GetAxis("Mouse X");
            pitch -= speedV * Input.GetAxis("Mouse Y");

            // limit the rotation of the camera.
            yaw = Mathf.Clamp(yaw, minH, maxH);
            pitch = Mathf.Clamp(pitch, minV, maxV);

            transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }
        
    }
}
