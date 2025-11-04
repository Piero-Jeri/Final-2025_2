using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameManager Manager;

    public List<EnemyDataSO> EnemysData = new();
    public GameObject EnemyPrefab;
    public Transform EnemyHolderTransform;
    [SerializeField] private float timeToSpawn = 5;
    private float currentTime;

    [SerializeField] private List<GameObject> enemies = new();

    void Start()
    {

    }
    void Update()
    {
        Spawner();
    }
    public void Spawner()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timeToSpawn)
        {
            GameObject enemy = Instantiate(EnemyPrefab, EnemyHolderTransform);
            enemy.GetComponent<BaseEnemy>().data = EnemysData[Random.Range(0, EnemysData.Count)];

            float randomX = Random.Range(-5, 5);
            float randomY = Random.Range(-5, 5);
            enemy.transform.position = new Vector3(randomX, randomY, 0);

            enemies.Add(enemy);
            currentTime = 0;
        }
    }
    public void DeleteAllEnemies()
    {
        Debug.Log("Eliminaste los enemigos");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();

    }
}