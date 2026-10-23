using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab;
    float timer = 0;
    [SerializeField] float atkInterval = 0.5f; // 攻撃間隔を設定
    public PlayerController playerController;

    void Start()
    {
        // インスペクターで設定されていない場合、シーン内から自動でPlayerControllerを探して取得する
        if (playerController == null)
        {
            playerController = Object.FindAnyObjectByType<PlayerController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= atkInterval)
        {
                Instantiate(bulletPrefab, new Vector3(playerController.transform.position.x, -3.5f, 0), Quaternion.identity);
                timer = 0; // Reset the timer after shooting
            
        }
    }
}

