using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Camera;
    public Transform Player;


    void Start()
    {
        ;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.position = new Vector3(Player.position.x, 12, -58);
        //set the vector position acording to your needs
        
    }
}
