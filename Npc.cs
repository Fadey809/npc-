using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    //�������� ���
    public int health = 5;

    //������� ���
    public int levle = 1;

    //�������� ���
    public float speed = 1.3f;


    // Start is called before the first frame update
    void Start()
    {

        health = health + levle;
        print("������:" +  health);
        
    }

    // Update is called once per frame
    void Update()
    {
        //������� ��������� Vector3 � ��������� � ������� ��� ���
        Vector3 newPosition = transform.position;
        
    }
}
