using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //Здоровье нпс
    public int health = 5;

    //уровень нпс
    public int levle = 1;

    //скорость нпс
    public float speed = 1.3f;


    // Start is called before the first frame update
    void Start()
    {

        health = health + levle;
        print("Жизней:" +  health);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Создаем переменую Vector3 и сохроняем её позицию для нпс
        Vector3 newPosition = transform.position;
        
    }
}
