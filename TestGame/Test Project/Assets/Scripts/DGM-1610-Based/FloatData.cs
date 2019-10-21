using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    [SerializeField] private float value; // visible in editor?
    public float Value { //visible in events system
        get { return value; }
        set { this.value = value; }
    }
    
    public void UpdateValue(float floatInput) {
        Value += floatInput;	
    }

    public void UpdateValue(FloatData dataObj)
    {
        Value += dataObj.Value;
    }

    /*public void Init(float Value)
    {
	    this.Value = Value;
    }
    public static FloatData CreateInstance(float Value)
    {
	    var data = ScriptableObject.CreateInstance<FloatData>();
	    data.Init(Value);
	    return data;
    }*/
    //Source for Init and CreateInstance https://answers.unity.com/questions/310847/how-to-create-instance-of-scriptableobject-and-pas.html

}
//Taken from script from DGM 1610 project