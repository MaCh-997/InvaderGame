using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    float timer = 0;
    [SerializeField] float atkInterval = 0.5f; // 攻撃間隔を設定
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= atkInterval)
        {
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                timer = 0; // Reset the timer after shooting
            
        }
    }
}
