// script moves camera up

using UnityEngine;

public class CameraMoveUpEvent : TimelineEvent
{
    [SerializeField] private Camera targetCamera; // reference to the target camera
    [SerializeField] private Vector3 movement;
    
    public override void Execute()
    {
        if (targetCamera != null)
        {
            targetCamera.position += movement; // move the camera to the new position
        }
        else
        {
            Debug.LogWarning("CameraMoveUpEvent: Target camera transform is null.");
        }
    }
}