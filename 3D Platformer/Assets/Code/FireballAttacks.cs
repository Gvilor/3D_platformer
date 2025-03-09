using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttacks : MonoBehaviour
{
    //Переменная для огненного шара
    public GameObject fireballPrefab;
    //Точка вылета шара 
    public Transform attackPoint;

    void Update()
    {
        //Если игрок нажимает левую кнопку мыши, создается огненный шар
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
