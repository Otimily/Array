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

        new Doll("1번 학생", 50, 50),
        new Doll("2번 학생", 20, 50),
        new Doll("3번 학생", 30, 80),
        new Doll("4번 학생", 40, 70),
        new Doll("5번 학생", 70, 35),
        new Doll("6번 학생", 45, 90),
    };

    void Start()
    {
        for (int i = 0; i < dolls.Length; i++)
        {
            Debug.Log($"학생이름 : {dolls[i].Name}    공격점수 : {dolls[i].attackScore}    마법점수 : {dolls[i].magiScore}    평균 : {dolls[i].GetAverage()}");
        }

        rank();
    }


    // 등급 구하는 함수
    public void rank()
    {
        // 평균
        // 60점 이상은 A
        // 55점 이상은 B
        // 50점 이상은 C
        // 50점 미만는 D

        for (int i = 0; i < dolls.Length; i++)
        {
            string a = "";

            if (dolls[i].GetAverage() >= 60)
            {
                a = "A등급";
            }

            else if (dolls[i].GetAverage() >= 55)
            {
                a = "B등급";
            }

            else if (dolls[i].GetAverage() >= 50)
            {
                a = "C등급";
            }

            else if (dolls[i].GetAverage() < 50)
            {
                a = "D등급";
            }

            Debug.Log($"{dolls[i].Name}의 평균은 {dolls[i].GetAverage()}입니다. 등급은 {a}");
        }

        
    }

};
