using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 10f;          // Speed of enemy movement
    public float moveDistance = 5f;    // Maximum distance to move forward and backward
    public float waitTime = 0.5f;      // Time to wait at each end point

    private Vector3 startPosition;     // Starting position of the enemy
    private Vector3 targetPosition;    // Target position to move toward
    private bool movingForward = true;

    void Start()
    {
        startPosition = transform.position;                        // Store the initial position
        targetPosition = startPosition + Vector3.forward * moveDistance; // Initial target is forward
        StartCoroutine(MoveBackAndForth()); // Start the movement coroutine
    }

    private IEnumerator MoveBackAndForth()
    {
        while (true)
        {
            // Move towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            // Check if the enemy has reached the target position
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                yield return new WaitForSeconds(waitTime); // Pause at each end

                // Reverse direction: toggle between moving forward and backward
                if (movingForward)
                    targetPosition = startPosition; // Move back to start
                else
                    targetPosition = startPosition + Vector3.forward * moveDistance; // Move forward

                movingForward = !movingForward; // Toggle direction
            }

            yield return null;
        }
    }
}
