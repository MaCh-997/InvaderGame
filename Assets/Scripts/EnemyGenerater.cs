using UnityEngine;

public class EnemyGenerater : MonoBehaviour
{
    public GameObject enemyPrefab; // Enemy prefab to instantiate
    public Transform parentObject; // Parent object to hold the instantiated enemies
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                GameObject go = Instantiate(enemyPrefab,
                                            new Vector3(-2f + x * 1f, y*1f+1.0f, 0),
                                            Quaternion.identity,
                                            parentObject);
            }
        }
    }
}
