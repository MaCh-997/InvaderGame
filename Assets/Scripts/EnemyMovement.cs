using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    int moveDirection = 1; // 1 for right, -1 for left
    int moveCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveCount++;

        if (moveCount >= 500) // Change direction every 500 frames
        {
            moveDirection *= -1; // Reverse direction
            moveCount = 0; // Reset count
        }

        transform.Translate(Vector3.right * moveDirection * Time.deltaTime);
    }
}
