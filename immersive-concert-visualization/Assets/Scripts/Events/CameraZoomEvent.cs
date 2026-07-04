// script changes field of view

using UnityEngine;

public class CameraZoomEvent : TimelineEvent
{
    [SerializeField] private Camera targetCamera; // reference to the target camera
    // if targetFieldOfView = 30 (zoom in) or 80 (zoom out)
    [SerializeField] private float targetFieldOfView = 60f; // the field of view to apply to the camera
    
    public override void Execute()
    {
        if (targetCamera != null)
        {
            targetCamera.fieldOfView = targetFieldOfView; // move the camera to the new position
        }
        else
        {
            Debug.LogWarning("CameraZoomEvent: Target camera transform is null.");
        }
    }
}