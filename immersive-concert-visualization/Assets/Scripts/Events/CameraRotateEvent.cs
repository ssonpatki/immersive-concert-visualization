// script rotates the camera

using UnityEngine;

public class CameraRotateEvent : TimelineEvent
{
    [SerializeField] private Camera targetCamera; // reference to the target camera
    [SerializeField] private Vector3 targetRotation; // the rotation to apply to the camera
    
    public override void Execute()
    {
        if (targetCamera != null)
        {
            targetCamera.transform.eulerAngles = targetRotation; // move the camera to the new position
        }
        else
        {
            Debug.LogWarning("CameraRotateEvent: Target camera transform is null.");
        }
    }
}