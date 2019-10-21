using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu]
public class StateMachine : ScriptableObject
{
    
    public UnityEvent StartingEvent, PlayingEvent, EndingEvent;
    public Counter Count;
    
    public enum States
    {
        Starting,
        Playing,
        Ending
    }

    public States CurrentStates;
    
    //Toward end of Stream on 4/1/2019: Introduces hard-coded dynamic alternatives if doesn't work?

    public void OnSwitch()
    {
        switch (CurrentStates)
        {
            case States.Starting:
                StartingEvent.Invoke();
                break;
            case States.Playing:
                PlayingEvent.Invoke();
                break;
            case States.Ending:
                EndingEvent.Invoke();
                break;
            default:
                //Work
                break;
        }
    }
}
//Taken from script from DGM 1610 project