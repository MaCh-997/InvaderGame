using UnityEngine;

public class EnemyParentMovement : MonoBehaviour
{
    int moveDirection = 1;
    [SerializeField] float moveSpeed = 2.0f;
    [SerializeField] public float Rightlimit = 5.0f;
    [SerializeField] public float Leftlimit = -5.0f;

    void Update()
    {
        transform.Translate(Vector3.right * moveDirection * moveSpeed * Time.deltaTime);

        if (transform.position.x >= Rightlimit) moveDirection = -1;
        else if (transform.position.x <= Leftlimit) moveDirection = 1;
    }
}