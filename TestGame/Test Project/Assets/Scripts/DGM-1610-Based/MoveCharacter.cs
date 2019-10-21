using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
    private CharacterController controller;
    public UnityEvent OnGrounded, OffGrounded;
    //^AnimateNormalArm, AnimateMechanicalArm

    public MoveBase CharacterMover;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //NOT USED: AnimateNormalArm.Invoke();
        //NOT USED: AnimateMechanicalArm.Invoke();
        //Find a way to tie these to sprite animation, how to flip layer prominence and orientation based on character direction
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded) {
            OnGrounded.Invoke();
        } else {
            OffGrounded.Invoke();
        }

        CharacterMover.Move(controller);


    }
}
//Taken from script from DGM 1610 project