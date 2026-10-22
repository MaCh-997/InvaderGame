using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    int moveDirection = 1; // 1 for right, -1 for left
    [SerializeField] private float moveSpeed = 2.0f;
    [SerializeField] private float moveDistance = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveDirection * moveSpeed * Time.deltaTime);

        // 画面中央（X=0）を基準として、左右の限界（m_limitX）を超えたら方向を反転する
        if (transform.position.x >= moveDistance)
        {
            moveDirection = -1; // 左へ移動
        }
        else if (transform.position.x <= -moveDistance)
        {
            moveDirection = 1; // 右へ移動
        }
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
