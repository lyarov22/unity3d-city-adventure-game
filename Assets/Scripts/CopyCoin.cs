using UnityEngine;

public class CopyCoin : MonoBehaviour
{
    public GameObject coinPrefab;   // префаб монеты
    public float spawnInterval = 5f;   // интервал спавна
    public int spawnCount = 50;   // количество спавнов

    void Start()
    {
        SpawnCoins();
    }

    void SpawnCoins()
    {
        Vector3 spawnPosition = transform.position;   // позиция спавна
        for (int i = 0; i < spawnCount; i++)
        {   
            GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);   // создаем новую монету
            spawnPosition.z -= spawnInterval;   // смещаем позицию спавна по оси Z на 10 метров
            coin.transform.Rotate(90f, 0f, 90f);
        }
    }
}