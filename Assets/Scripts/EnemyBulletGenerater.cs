using UnityEngine;

public class EnemyBulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    float timer = 0;
    [SerializeField] float atkInterval = 0.5f; // 攻撃間隔を設定
    public EnemyGenerater enemyGenerater;

    void Start()
    {
        if (enemyGenerater == null)
        {
            enemyGenerater = Object.FindAnyObjectByType<EnemyGenerater>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= atkInterval)
        {
            //Instantiate(bulletPrefab, new Vector3(enemyGenerater.transform.position.x, 0, 0), Quaternion.identity);
            Instantiate(bulletPrefab, new Vector3(Random.Range(-2.5f, 2.5f), 0, 0), Quaternion.identity);
            timer = 0; // Reset the timer after shooting
        }
    }
}

