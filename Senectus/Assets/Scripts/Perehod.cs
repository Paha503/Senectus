using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Perehod : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) //Для 2D - в нашем случае, это событие выполняться не будет.
    {
        if (other.gameObject.tag == "Player") //Проверяем тэг объекта. Убедись, что у Игрока есть тег Player
        {
            SceneManager.LoadScene("grass"); //Загружаем сцену
        }
    }
}
