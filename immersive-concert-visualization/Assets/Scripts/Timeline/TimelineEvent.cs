// contains TimelineEvent base class

using UnityEngine;

public class TimelineEvent : MonoBehaviour
{
    public float triggerTime; // time in seconds when the event should be triggered

    // method to be called when the event is triggered
    public virtual void TriggerEvent()
    {
        Debug.Log("TimelineEvent triggered at time: " + triggerTime);
    }
}