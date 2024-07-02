using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayObjetos : MonoBehaviour
{
    public GameObject[] objetos;
    int orden;

    void Start()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            objetos[i].SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            objetos[orden].SetActive(false);
            orden--;
            if (orden == -1)
            {
                orden = objetos.Length - 1;
            }
            objetos[orden].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            objetos[orden].SetActive(false);
            orden++;
            if (orden == objetos.Length)
            {
                orden = 0;
            }
            objetos[orden].SetActive(true);
        }
    }
}
