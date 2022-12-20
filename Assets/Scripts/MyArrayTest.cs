using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArrayTest : MonoBehaviour
{
    public int[] doll = { 3, 8, 9, 1, 5, 2, 7, 2, 12, 6 };

    void Start()
    {
        int max = 0;
        for (int i = 0; i < doll.Length; i++)
        {
            if (doll[max] < doll[i]) //i가 max보다 클 때 최대값을 구한다
            {
                max = i;
            }
        }
        Debug.Log("점수가 가장 높은 인형 : " + doll[max]);

        //==========================================

        int min = 0;
        for (int i = 1; i < doll.Length; i++)
        {
            if (doll[min] > doll[i]) //i가 min보다 작을 때 최솟값을 구한다
            {
                min = i;
            }
        }
        Debug.Log("점수가 가장 낮은 인형 : " + doll[min]);

        //============================================

        int tmp = doll[2];
        doll[2] = doll[min];
        doll[min] = tmp;

    }
}