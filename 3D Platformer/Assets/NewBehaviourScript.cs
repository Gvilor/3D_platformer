using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider Other)//Метод когда входим
    {
        Other.GetComponent<FirstPersonMovement>().speed *= speedFactor;
    }


    void OnTriggerExit(Collider Other)//Метод когда выходим
    {
        Other.GetComponent<FirstPersonMovement>().speed /= speedFactor;
    }

}
