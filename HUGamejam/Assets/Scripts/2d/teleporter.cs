using UnityEngine;

public class teleporter : MonoBehaviour
{
    public Vector3 destinationPosition; // Set the destination position in the Unity Editor
    public int maxTriggerCount = 5; // Set the maximum trigger count in the Unity Editor

    private int currentTriggerCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        {
            MoveObjectToDestination(other.gameObject);
            currentTriggerCount++;

            if (currentTriggerCount >= maxTriggerCount)
            {
                // Stop further triggering by disabling the script
                enabled = false;
            }
        }
    }

    private void MoveObjectToDestination(GameObject objToMove)
    {
        if (objToMove != null)
        {
            objToMove.transform.position = destinationPosition;
        }
    }
}
