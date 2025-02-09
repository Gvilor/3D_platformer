using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //Скорость огненного шара
    public float speed;
    
    void Update() //Происходит каждый кадр(Движение)
    {
        Destroy(gameObject, 3);
        //каждый кадр позиция шара меняется 
        transform.position += transform.forward * speed * Time.deltaTime;

        print(transform.forward);
    }

    public void OnTriggerEnter(Collider other)
    {
        //Уничтожение врага 
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);

        //Уничтожение снаряда 
        Destroy(gameObject);
    }
}
