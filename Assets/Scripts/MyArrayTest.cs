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
            if (doll[max] < doll[i]) //i�� max���� Ŭ �� �ִ밪�� ���Ѵ�
            {
                max = i;
            }
        }
        Debug.Log("������ ���� ���� ���� : " + doll[max]);

        //==========================================

        int min = 0;
        for (int i = 1; i < doll.Length; i++)
        {
            if (doll[min] > doll[i]) //i�� min���� ���� �� �ּڰ��� ���Ѵ�
            {
                min = i;
            }
        }
        Debug.Log("������ ���� ���� ���� : " + doll[min]);

        //============================================

        int tmp = doll[2];
        doll[2] = doll[min];
        doll[min] = tmp;

    }
}