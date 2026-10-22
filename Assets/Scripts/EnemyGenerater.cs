using UnityEngine;

public class EnemyGenerater : MonoBehaviour
{
    public GameObject enemyPrefab; // Enemy prefab to instantiate
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 5; x++)
            {
                GameObject go = Instantiate(enemyPrefab,
                                            new Vector3(-2f + x * 1f, y*1f+1.0f, 0),
                                            Quaternion.identity);
            }
        }
    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Hit!");
            Destroy(collision.gameObject); // Destroy the bullet
            Destroy(gameObject); // Destroy the enemy
        }
    }*/
}
