using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Переменная для огненного шара
    public GameObject fireballPrefab;
    // Точка вылета шара 
    public Transform attackPoint;

    //Максимальное здоровье игрока
    private int health = 10;

    //Метод понижающий здоровье игрока
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока = " + health);
    }

    void Update()
    {
        //Если игрок нажимает левую кнопку мыши, создается огненный шар
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
