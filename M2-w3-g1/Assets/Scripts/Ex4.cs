using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    [SerializeField] private int size;
    [SerializeField] private int minValue;
    [SerializeField] private int maxValue;

    int[] GenerateArr(int size, int min, int max)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Random.Range(min, max+1);
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

    void FindMax2(int[] arr)
    {
        int maxValue = int.MinValue; 
        ;
        int secondMax = int.MinValue;

        for(int i=0; i< arr.Length; i++)
        {
            if (arr[i] > maxValue)
            {
                secondMax = maxValue;
                //Debug.Log("primo if prima della sostituzione "+maxValue);
                maxValue = arr[i];
                //Debug.Log("primo if dopo della sostituzione " + maxValue);
                //Debug.Log(i + "ciclo di riferimento");


            }
            else if (arr[i] > secondMax && arr[i] != maxValue)
            {
                //Debug.Log("secondo if prima della sostituzione" + secondMax);
                //Debug.Log(" secondo if valore dell'array in questo momento "+arr[i]);
                secondMax = arr[i];
                //Debug.Log("secondo if dopo della sostituzione" + secondMax);
                //Debug.Log(i + "ciclo di riferimento");

            }
            // codice di verifica
            //if (arr[i] != secondMax) {
            //    bool ver = arr[i] != 3;
            //    Debug.Log("è diverso da tre"+ver);
            //    Debug.Log("valore in questo momento" + arr[i]);
            
            //}
        }
        Debug.Log("il valore maggiore è " + maxValue + " il secondo maggiore è " + secondMax);
    }
    void FindMin2(int[] arr)
    {
        int minValue = int.MaxValue;
        int secondMin = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < minValue)
            {
                secondMin = minValue;
                minValue = arr[i];

            }
            else if (arr[i] < secondMin && arr[i]!= minValue)
            {
                secondMin = arr[i];
            }
        }
        Debug.Log("il valore minore è " + minValue + " il secondo minore è " + secondMin);
    }
    void Start()
    {
        int[] arr = GenerateArr(size, minValue, maxValue);
        PrintArr(arr);
        FindMax2(arr);
        FindMin2(arr); 
    }

    
   
}
