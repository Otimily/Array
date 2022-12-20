using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Doll 
{
    public string Name;
    public int attackScore;
    public int magiScore;

    public Doll(string Name, int attackScore, int magiScore)
    {
        this.Name = Name;
        this.attackScore = attackScore;
        this.magiScore = magiScore;
    }


    public float GetAverage()
    {
        float average = (float)(attackScore + magiScore) / 2;

        return average;
    }
}


public class ArrayTest : MonoBehaviour
{
    public Doll[] dolls = {

        new Doll("1�� �л�", 50, 50),
        new Doll("2�� �л�", 20, 50),
        new Doll("3�� �л�", 30, 80),
        new Doll("4�� �л�", 40, 70),
        new Doll("5�� �л�", 70, 35),
        new Doll("6�� �л�", 45, 90),
    };

    void Start()
    {
        for (int i = 0; i < dolls.Length; i++)
        {
            Debug.Log($"�л��̸� : {dolls[i].Name}    �������� : {dolls[i].attackScore}    �������� : {dolls[i].magiScore}    ��� : {dolls[i].GetAverage()}");
        }

        rank();
    }


    // ��� ���ϴ� �Լ�
    public void rank()
    {
        // ���
        // 60�� �̻��� A
        // 55�� �̻��� B
        // 50�� �̻��� C
        // 50�� �̸��� D

        for (int i = 0; i < dolls.Length; i++)
        {
            string a = "";

            if (dolls[i].GetAverage() >= 60)
            {
                a = "A���";
            }

            else if (dolls[i].GetAverage() >= 55)
            {
                a = "B���";
            }

            else if (dolls[i].GetAverage() >= 50)
            {
                a = "C���";
            }

            else if (dolls[i].GetAverage() < 50)
            {
                a = "D���";
            }

            Debug.Log($"{dolls[i].Name}�� ����� {dolls[i].GetAverage()}�Դϴ�. ����� {a}");
        }

        
    }

};
