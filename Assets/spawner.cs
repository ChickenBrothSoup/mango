using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int RareSpawn = 10;

    public GameObject potatoPrefab;
    public GameObject RarePotato;

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

    int currentChance = Random.Range(0, 100);

    if (currentChance > RareSpawn)
    {

            if (potatoPrefab)
            {
                Vector3 randomposition = new Vector3(
                    Random.Range(MinMaxPos.x, MinMaxPos.y),
                    transform.position.y,
                    transform.position.z
                    );

                GameObject.Instantiate(potatoPrefab,
                     randomposition, Quaternion.identity);
            }
        }
        else
        {
            if (RarePotato)
            {
                Vector3 randomposition = new Vector3(
                    Random.Range(MinMaxPos.x, MinMaxPos.y),
                    transform.position.y,
                    transform.position.z
                    );

                GameObject.Instantiate(RarePotato,
                     randomposition, Quaternion.identity);
            }






        }

        spawnTimer = SpawnInterval;

    }

}
