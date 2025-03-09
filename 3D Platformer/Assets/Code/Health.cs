using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//библиотека дл€ смены сцены
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{

    //“екущее здоровье игрока
    public int health = 10;
    //ћаксимальное здоровье игрока
    public int maxHealth = 10;

    //проигрывание звука
    public AudioSource audioSource;
    //файл содержащий звук урона
    public AudioClip damageSound;

    //ћетод понижающий здоровье игрока
    public void TakeDamage(int damage)
    {

        health -= damage; // уменьшаем здоровье

        if (health > 0)
        {
            print("«доровье игрока = " + health); //выводим кол-во жизней
            audioSource.PlayOneShot(damageSound);//воспроизведение звука урона
        }
        else
        {
            //ѕолучение индекса текущей сцены и ее перезапуск
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
