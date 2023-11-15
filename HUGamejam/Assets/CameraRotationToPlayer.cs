using UnityEngine;

public class CameraRotationToPlayer : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public Camera mainCamera;

    void Update()
    {
        // Get the camera's forward direction without considering its Y component
        Vector3 cameraForward = mainCamera.transform.forward;
        cameraForward.y = 0f;
        cameraForward.Normalize();

        // Calculate the rotation angle based on the camera's forward direction
        Quaternion targetRotation = Quaternion.LookRotation(cameraForward);

        // Smoothly rotate the player towards the target rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}