using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //Имя сцены, которую нужно перезапустить
    public string sceneName;


    void OnTriggerEnter()
    {
        //Перезапуск сцены
        SceneManager.LoadScene(sceneName);
    }
}
