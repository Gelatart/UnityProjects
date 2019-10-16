using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
    protected Vector3 position;
    public float JumpForce = 3.5f;
    public float Gravity = -3;
    public float Speed = 30;
    public abstract void Move(CharacterController controller);
}
//Taken from script from DGM 1610 project