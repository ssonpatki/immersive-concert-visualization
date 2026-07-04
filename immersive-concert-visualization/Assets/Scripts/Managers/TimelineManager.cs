// responsibilities:
    // ask audiomanager for curr song time
    // store list of event
    // trigger each event once corresponding timestamp reached

using UnityEngine;  // import unity core library
using System.Collections.Generic;   // since using List<>

// class TimelineManager inheriting from MonoBehavior (i.e., can be attached to gameobject)
public class TimelineManager : MonoBehaviour
{
    [SerializeField] private List<TimelineEvent> timelineEvents = new List<TimelineEvent>();  // store list of events

    private void Update()
    {
        float currentTime = AudioManager.Instance.CurrentTime;  // ask audiomanager for curr song time
        
        for (int i = 0; i < timelineEvents.Count; i++)
        {
            if (timelineEvents[i].triggerTime <= currentTime && !timelineEvents[i].hasExecuted)
            {
                timelineEvents[i].Execute();  // trigger each event once corresponding timestamp reached
                timelineEvents[i].hasExecuted = true;
            }
        }
    }
}