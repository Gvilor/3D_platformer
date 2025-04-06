using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Библиотека для работы с интерфейсом
using TMPro;//Библиотека для работы с текстом 

public class PlayerUI : MonoBehaviour
{
    public CoinsCounter coinsCount;
    public Health health;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
            
    void Update()
    {
        //Обновляем значение здоровья игрока
        healthSlider.maxValue = health.maxHealth;
        healthSlider.value = health.health;

        //Обновляем текст с кол-вом монеток
        coinsCounterText.text = coinsCount.coins.ToString();
    }
}
