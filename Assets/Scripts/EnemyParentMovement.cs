using UnityEngine;

public class EnemyParentMovement : MonoBehaviour
{
    int moveDirection = 1;
    float timer = 0.0f; 
    [SerializeField] float moveSpeed = 2.0f;
    [SerializeField] public float Rightlimit = 5.0f;
    [SerializeField] public float Leftlimit = -5.0f;

    void Update()
    {
        timer += Time.deltaTime;
        transform.Translate(Vector3.right * moveDirection * moveSpeed * Time.deltaTime);

        if (transform.position.x >= Rightlimit) moveDirection = -1;
        else if (transform.position.x <= Leftlimit) moveDirection = 1;

        if (timer >= 10.0f)
        {
            transform.Translate(Vector3.down * 0.5f);
            timer = 0.0f;
        }
    }
}