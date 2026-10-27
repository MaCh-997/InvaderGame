using UnityEngine;

public class LifeCount : MonoBehaviour
{
    [SerializeField] private int lifeCount = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            Debug.Log("Damaged!");
            Destroy(collision.gameObject); // Destroy the bullet
            lifeCount--; // Decrease life count
            if (lifeCount <= 0)
            {
                Debug.Log("Game Over!");
                // Handle game over logic here
            }
        }
    }
}
