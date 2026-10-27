using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] float atkInterval = 2.0f;
    [SerializeField] Vector3 spawnOffset = new Vector3(0, -0.5f, 0); // 敵の少し下から出す

    float timer;

    void Start()
    {
        // 12体が同時に撃たないよう、発射タイミングをずらす
        timer = Random.Range(0f, atkInterval);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= atkInterval)
        {
            // 敵の現在のワールド座標(x, y)から生成。親は指定しない
            Instantiate(bulletPrefab, transform.position + spawnOffset, Quaternion.identity);
            timer = 0;
        }
    }
}