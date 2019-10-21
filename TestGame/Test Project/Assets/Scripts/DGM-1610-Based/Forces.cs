using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class Forces : MonoBehaviour
{
    public Vector3 ForceAmount;
    private Rigidbody rBody;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }
   
    public void ApplyForce()
    {
        rBody.AddForce(ForceAmount);
        //was a float force: 0,force,0
        //Set ForceAmount in Forces script on sphere in Unity now
    }
}
//Taken from script from DGM 1610 project