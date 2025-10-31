using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    
    [SerializeField] private int[] arr;
    [SerializeField] private int newDim;
    void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }
    int[] ChangeArr(int[]arr, int dim)
    {
        if (arr.Length == dim)
        {
            //Debug.Log("d");
            return arr;
           
        }
        else
        {
            int[] secondArr = new int[dim];
            for (int i = 0; i < dim; i++)
            {
                // se uso > risulta inesistente la casella dall'array, mentre con >= la trova, trovato risposta semplicemente se non è maggiore esegue else e di fatto non trova 
                // la casella in più su arr che non esiste, mentre su if la casella su secondArr esiste e gli posso mettere un valore
                if (i >= arr.Length) 
                {
                    secondArr[i] = 0;
                   
                }
                else
                {
                    secondArr[i] = arr[i];
                }
            }
            //Debug.Log("dadadadadadadadad");
            return secondArr;
            
        }
       
    }
    void Start()
    {
      Debug.Log("originale");
      PrintArr(arr);
      arr = ChangeArr(arr, newDim);
      Debug.Log("a piacimento");
      PrintArr(arr);
      arr =ChangeArr(arr, arr.Length+5);
      Debug.Log("aggiungiendo");
      PrintArr(arr);
      arr = ChangeArr(arr, arr.Length-7);
      Debug.Log("togliendo");
      PrintArr(arr);
      arr = ChangeArr(arr, arr.Length);
      Debug.Log("lasciando invariato");
      PrintArr(arr);
      


    }

    
}
