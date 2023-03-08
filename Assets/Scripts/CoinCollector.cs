using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    // Переменная, которая хранит количество собранных монет
    private int coins;

    private void Start()
    {
        coins = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    // Вызывается, когда коллайдер персонажа касается коллайдера монеты
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // Уничтожаем объект монеты
            Destroy(other.gameObject);

            // Прибавляем 1 к переменной coins
            coins -= 1;
        }
    }

    void OnGUI()
    {
        Rect scoreRect = new Rect(10, 10, 100, 20);

        // Отображение текстового поля на экране с текущим значением переменной "score"
        GUI.Label(scoreRect, "Score: " + coins);
    }
}