using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed; //Скорость движения
    public Vector3 direction; //направление движения
    public bool isActive; //состояние платформы

    void Update()
    {
        if (isActive)
        {
            transform.position += direction * speed * Time.deltaTime;
        }
    }

}
