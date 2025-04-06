using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        CoinsCounter coins = other.GetComponent<CoinsCounter>();
        //Количество монеток обновляется
        coins.CollectCoins();
        //Монетку уничтожаем
        Destroy(gameObject);
    }
}
