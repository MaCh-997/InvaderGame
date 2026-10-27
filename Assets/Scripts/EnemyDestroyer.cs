using UnityEngine;

public class EnemyDestroyer : MonoBehaviour
{
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
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Hit!");
            Destroy(collision.gameObject); // Destroy the bullet
            Destroy(gameObject); // Destroy the enemy
        }
    }
}
