using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed; //Скорость движения
    public Vector3 direction; //направление движения
    public bool isActive; //состояние платформы

    void Update() // Движение платформы
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "PlatfromStop") //Если касаемся одну из точек
        {
            direction *= -1;//Меняем направление
        }
        if (other.tag == "Player")//Если касаемся игрока
        {
            isActive = true;//Включить платформу
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Player")//Если касаемся игрока
        {
            isActive = false;//Выключить платформу
        }
    }

}
