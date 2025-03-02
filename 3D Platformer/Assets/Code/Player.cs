using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Перменная для хранения монет
    public int coins;
    //Переменная для огненного шара
    public GameObject fireballPrefab;
    //Точка вылета шара 
    public Transform attackPoint;

    //Текущее здоровье игрока
    public int health = 10;
    //Максимальное здоровье игрока
    public int maxHealth = 10;

    //проигрывание звука
    public AudioSource audioSource;
    //файл содержащий звук урона
    public AudioClip damageSound;

    public void CollectCoins()
    {
        coins++; //Добавляем 1 монетку
        print("Собранные монетки: " +  coins);//Выводим значение монеток
    }

    //Метод понижающий здоровье игрока
    public void TakeDamage(int damage)
    {
        health -= damage; // уменьшаем здоровье

        if (health > 0)
        {
            print("Здоровье игрока = " + health); //выводим кол-во жизней
            audioSource.PlayOneShot(damageSound);//воспроизведение звука урона
        }
        else
        {

            //Получение индекса текущей сцены и ее перезапуск
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
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
