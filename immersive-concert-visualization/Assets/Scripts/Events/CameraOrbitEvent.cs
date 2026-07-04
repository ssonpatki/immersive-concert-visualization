// script starts orbit movement

using UnityEngine;

public class CameraOrbitEvent : TimelineEvent
{
    [SerializeField] private Camera targetCamera; // reference to the target camera
    [SerializeField] private Transform orbitTarget; // empty gameobject @ center of scene
    [SerializeField] private float angle = 90f; // the angle to rotate the camera around the target point
    
    public override void Execute()
    {
        if (targetCamera != null && orbitTarget != null)
        {
            targetCamera.transform.RotateAround(
                orbitTarget.position,
                Vector3.up,
                angle
            ) 
        }
        else
        {
            Debug.LogWarning("CameraOrbitEvent: Target camera transform is null.");
        }
    }
}