using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] private int size;
    [SerializeField] private int minValue;
    [SerializeField] private int maxValue;

    int[] GenerateArr(int size, int min, int max)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(min, max);
        }
        return arr;
    }
    void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }

    void FindMin(int[] arr)
    {
        int min = 1113456789;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Debug.Log("il minore è " + min);
    }
    void FindMax(int[] arr)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Debug.Log("il maggiore è " + max);
    }
    void Start()
    {
        int[] arr = GenerateArr(size, minValue, maxValue);
        PrintArr(arr);
        FindMax(arr);
        FindMin(arr);

    }


}
