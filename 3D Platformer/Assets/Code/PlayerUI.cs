using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Библиотека для работы с интерфейсом
using TMPro;//Библиотека для работы с текстом 

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        //Обновляем значение здоровья игрока
        healthSlider.maxValue = player.maxHealth;
        healthSlider.value = player.health;

        //Обновляем текст с кол-вом монеток
        coinsCounterText.text = player.coins.ToString();
    }
}
