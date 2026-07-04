// contains TimelineEvent base class
    // beginning of event system

using UnityEngine;

public class TimelineEvent : MonoBehaviour
{
    public float triggerTime; // time in seconds when the event should be triggered
    public bool hasExecuted = false; // flag to check if the event has already been executed
    
    // method to be called when the event is triggered
    public virtual void Execute()
    {
        Debug.Log("TimelineEvent triggered at time: " + triggerTime);
    }
}