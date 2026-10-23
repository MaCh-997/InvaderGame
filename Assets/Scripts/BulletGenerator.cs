using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    float timer = 0;
    [SerializeField] float atkInterval = 0.5f; // 攻撃間隔を設定
    [SerializeField] int modeChange = 1;
    public PlayerController playerController;
    public EnemyMovement enemyMovement;

    void Start()
    {
        // インスペクターで設定されていない場合、シーン内から自動でPlayerControllerを探して取得する
        if (playerController == null && modeChange == 1)
        {
            playerController = Object.FindAnyObjectByType<PlayerController>();
        }else if (enemyMovement == null && modeChange == 2)
        {
            enemyMovement = Object.FindAnyObjectByType<EnemyMovement>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= atkInterval && modeChange == 1)
        {
                Instantiate(bulletPrefab, new Vector3(playerController.transform.position.x, -3.5f, 0), Quaternion.identity);
                timer = 0; // Reset the timer after shooting
        }else if (timer >= atkInterval && modeChange == 2)
        {
                Instantiate(bulletPrefab, new Vector3(enemyMovement.transform.position.x, 3.5f, 0), Quaternion.identity);
                timer = 0; // Reset the timer after shooting
        }
    }
}

