using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{

    public Transform player;
    
    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;
        
        //Rotate minimap, comment out if not working
        //transform.rotation = Quaternion.Euler(90f, player.eulerAngles.y, 0f);
    }
    //Sourced from: https://www.youtube.com/watch?v=28JTTXqMvOU
}
