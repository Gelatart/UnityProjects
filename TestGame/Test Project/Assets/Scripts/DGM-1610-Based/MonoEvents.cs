using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    
    public UnityEvent StartEvent, EnableEvent, DisableEvent, MouseDownEvent, MouseUpEvent, UpdateEvent, TriggerEnterEvent, CollisionEnterEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        StartEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateEvent.Invoke();
    }

    private void OnEnable()
    {
        EnableEvent.Invoke();
    }
    
    private void OnDisable()
    {
        DisableEvent.Invoke();
    }

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }
    
    private void OnMouseUp()
    {
        MouseUpEvent.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }

    private void OnCollisionEnter(Collision other)
    {
        CollisionEnterEvent.Invoke();
    }
}
//Taken from script from DGM 1610 project