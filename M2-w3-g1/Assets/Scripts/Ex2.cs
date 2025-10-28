using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    // variabili componente
    [SerializeField] private int number;
    [SerializeField] private int baseNum;
    [SerializeField] private int multiple;

    //funzione che restituisce un valore booleano
    bool IsEven(int num)
    {
        return (num % 2 == 0);
    }
    bool IsMultiple(int num, int multiple)
    {
        
        return (multiple%num==0);
    }
    void Start()
    {
        IsEven(number);
        IsMultiple(number, multiple);

        if (IsEven(number)) {
            Debug.Log("il numero " + number + " è pari");
        }else{
            Debug.Log("il numero " + number + " non è pari");

        }

        if(IsMultiple(baseNum, multiple))
        {
            Debug.Log("il numero " + multiple + " è un multiplo di " + baseNum);
        }
        else
        {
            Debug.Log("il numero " + multiple + " non è un multiplo di " + baseNum);

        }
        //Debug.Log("Il numero "+number+" è pari? "+ IsEven(number));
        //Debug.Log("il numero "+multiple+" è un multiplo di "+baseNum+"? "+IsMultiple(baseNum,multiple));
    }

    
    
}
