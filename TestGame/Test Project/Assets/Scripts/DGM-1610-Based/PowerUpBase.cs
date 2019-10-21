using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUpBase : ScriptableObject
{
    
    public float Value = 10.5f;
    public float ValueCap = 50f;
    
    
    // Start is called before the first frame update
    void OnEnable()
    {
        Value = 20f;
    }

    public void OnPowerUp(float addValue)
    {
        Value += addValue;
        if (Value > ValueCap)
        {
            Value = ValueCap;
        } 
        
    }
}
//Taken from script from DGM 1610 project