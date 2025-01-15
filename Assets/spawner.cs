using UnityEditor.XR;
using UnityEngine;

public class spawner : MonoBehaviour


{
    public GameObject potatoPrefab;

    public Vector2 MinMaxPos;

    public float SpawnInterval = 0.1f;

    private bool isSpawning = false;

    private float spawnTimer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = SpawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
            return;
        }


        if (potatoPrefab)
        {
            Vector3 randomposition= new Vector3(
                Random.Range(MinMaxPos.x, MinMaxPos.y),
                transform.position.y,
                transform.position.z
                );

            GameObject.Instantiate(potatoPrefab,
                 randomposition, Quaternion.identity);
        }
        

        spawnTimer = SpawnInterval;

    }
}
