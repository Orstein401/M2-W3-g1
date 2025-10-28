using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{

    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log("tabellina del " + i);
            for (int j = 1; j <=10; j++)
            {
                Debug.Log(i * j);
            }


        }
    }


}
