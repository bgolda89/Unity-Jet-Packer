using UnityEngine;

public class Object_Spawner : MonoBehaviour {

    public GameObject player;
    public GameObject[] coins;
    public GameObject[] trees;
    public GameObject enemy;
    private float coinSpawnTimer = 6.0f;
    private float enemySpawnTimer = 10.0f;
    private float treeSpawnTimer = 0.5f;

    void Start()
    {
        for (int i = 0; i < 80; i++)
        {
            Instantiate(trees[(Random.Range(0, trees.Length))], new Vector3(Random.Range(-70, 70), 0, Random.Range(6, 45)), Quaternion.identity);
        }
    }


    void Update () {
        coinSpawnTimer -= Time.deltaTime;
        enemySpawnTimer -= Time.deltaTime;
        treeSpawnTimer -= Time.deltaTime;
        if (!GameInit.gameOver)
        {
            if (coinSpawnTimer < 0.01)
            {
                SpawnCoins();
            }
            if (enemySpawnTimer < 0.01)
            {
                SpawnEnemy();
            }
            if (treeSpawnTimer < 0.01)
            {
                SpawnTree();
            } 
        }

	}

    void SpawnCoins()
    {
        Instantiate(coins[(Random.Range(0, coins.Length))], new Vector3(player.transform.position.x + 30, Random.Range(0, 5), 0), Quaternion.identity);
        coinSpawnTimer = Random.Range(1.0f, 3.0f);
    }

    void SpawnEnemy()
    {
        enemy.transform.localScale = new Vector3(Random.Range(0.5f, 3.5f), Random.Range(0.5f, 3.5f), Random.Range(0.5f, 3.5f));
        Instantiate(enemy, new Vector3(player.transform.position.x + 30, Random.Range(3, 9), 0), Quaternion.Euler (Random.Range(0,360), Random.Range(0,360), Random.Range(0, 360)));
        enemySpawnTimer = Random.Range(1.0f, 3.0f);
    }

    void SpawnTree()
    {
        Instantiate(trees[(Random.Range(0, trees.Length))], new Vector3(player.transform.position.x + 70, 0, Random.Range(6,45)), Quaternion.identity);
        treeSpawnTimer = Random.Range(0.05f, 0.2f);
    }
}
