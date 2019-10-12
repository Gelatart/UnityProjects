using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolatedFollow : MonoBehaviour {
    
    public GameObject objectToFollow;
    
    public float speed = 2.0f;
	private Vector3 offset;

	void Start() {
		offset = transform.position - objectToFollow.transform.position;
	}
    
    void LateUpdate () {
        float interpolation = speed * Time.deltaTime;
        
        Vector3 position = this.transform.position;
        //position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y+4.5f, interpolation);
		position.y = Mathf.Lerp(this.transform.position.y, objectToFollow.transform.position.y + offset.y, interpolation);
        position.x = Mathf.Lerp(this.transform.position.x, objectToFollow.transform.position.x + offset.x, interpolation);
		position.z = Mathf.Lerp(this.transform.position.z, objectToFollow.transform.position.z + offset.z, interpolation);
        //position.z = Mathf.Lerp(this.transform.position.z, objectToFollow.transform.position.z-7.0f, interpolation);
        //modifying values with additions so it will stay behind, need a better way to solve this issue
        this.transform.position = position;
		//this.transform.position = objectToFollow.transform.position + offset;
    }
    
    //Source used as inspiration: https://kylewbanks.com/blog/unity-make-camera-follow-player-smoothly-and-fluidly
    //Originally used in DGM 1610 project
	//Additional inspiration from Unity Roll-A-Ball Tutorial: https://learn.unity.com/project/roll-a-ball-tutorial
}
