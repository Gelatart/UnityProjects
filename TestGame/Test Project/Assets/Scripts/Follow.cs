using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {
    
    public GameObject objectToFollow;
    
    public float speed = 2.0f;
    
    void Update () {
        float interpolation = speed * Time.deltaTime;
        
        Vector3 position = this.transform.position;
        position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y+4.5f, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x, interpolation);
        position.z = Mathf.Lerp(this.transform.position.z, objectToFollow.transform.position.z-7.0f, interpolation);
        //modifying values with additions so it will stay behind, need a better way to solve this issue
        this.transform.position = position;
    }
    
    //Source used as inspiration: https://kylewbanks.com/blog/unity-make-camera-follow-player-smoothly-and-fluidly
    //Originally used in DGM 1610 project
}