using UnityEngine;

public class CameraMoveEvent : TimelineEvent
{
    [SerializeField] private Camera targetCamera; // reference to the target camera
    [SerializeField] private Transform targetCameraTransform; // reference to the target camera transform
    [SerializeField] private Vector3 targetPosition; // the position to move the camera to
    [SerializeField] private Quaternion targetRotation; // the rotation to rotate the camera to

    public CameraMoveEvent(Transform cameraTransform, Vector3 position, Quaternion rotation)
    {
        targetCameraTransform = cameraTransform;
        targetPosition = position;
        targetRotation = rotation;
    }

    public override void Execute()
    {
        if (targetCameraTransform != null)
        {
            targetCameraTransform.position = targetPosition; // move the camera to the new position
            targetCameraTransform.rotation = targetRotation; // rotate the camera to the new rotation
        }
        else
        {
            Debug.LogWarning("CameraMoveEvent: Target camera transform is null.");
        }
    }
}