using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCounter : MonoBehaviour
{
    //Перменная для хранения монет
    public int coins;

    public void CollectCoins()
    {
        coins++; //Добавляем 1 монетку
        print("Собранные монетки: " + coins);//Выводим значение монеток
    }
}
