using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Speed of player movement

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        // Get input for horizontal and vertical movement (WASD or Arrow keys)
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Create a movement vector based on input
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput) * moveSpeed * Time.deltaTime;

        // Apply the movement to the player's position
        transform.Translate(movement);
    }
}
