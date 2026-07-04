// script moves camera up

using UnityEngine;

public class CameraMoveUpEvent : TimelineEvent
{
    [SerializeField] private Transform targetTransform; // reference to the target camera
    [SerializeField] private Vector3 movement;
    
    public override void Execute()
    {
        if (targetTransform != null)
        {
            targetTransform.position += movement; // move the camera to the new position
            targetTransform.LookAt(Vector3.zero); // make the camera look at the origin (0,0,0)
        }
        else
        {
            Debug.LogWarning("CameraMoveUpEvent: Target camera transform is null.");
        }
    }
}