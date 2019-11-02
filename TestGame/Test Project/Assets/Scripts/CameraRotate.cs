using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
	//public GameObject target;
	public Transform focus;
	public float rotateSpeed;
	//private Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        //point = target.transform.position;
		//transform.LookAt(point);
    }

    // Update is called once per frame
    void Update()
    {
       //transform.Rotate(Vector3.up * Input.GetAxis("Horizontal"));
		//transform.LookAt(target.transform.position);
		//transform.Rotate(0,Input.GetAxis("Mouse X"),0);
    }
	//Inspirations: https://forum.unity.com/threads/rotate-the-camera-around-the-object.47353/    
	//https://stackoverflow.com/questions/26917333/how-can-i-turn-the-camera-to-left-and-right-with-mouse-in-unity-for-a-sphere
	void LateUpdate()
	{
    	if(Input.GetKey (KeyCode.E))
    	{
        	transform.RotateAround(focus.position, Vector3.up, rotateSpeed * Time.deltaTime);
    	}

    	else if(Input.GetKey (KeyCode.Q))
    	{
        	transform.RotateAround(focus.position, -Vector3.up, rotateSpeed * Time.deltaTime);
    	}
    	if(Input.GetKey (KeyCode.Z))
        {
	        transform.RotateAround(focus.position, -Vector3.right, rotateSpeed * Time.deltaTime); 
        }
            	
        else if(Input.GetKey (KeyCode.X)) 
        {
	        transform.RotateAround(focus.position, Vector3.right, rotateSpeed * Time.deltaTime);
		}
    	
	}
	//Inspiration: https://gamedev.stackexchange.com/questions/154078/how-do-i-rotate-the-camera-around-the-player-by-keypress-in-unity
}