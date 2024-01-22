using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploArray : MonoBehaviour
{
    // Ejemplo 1
    int _number = 12;
    int[] _numberArray = new int[4];

    // Ejemplo 2
    string[] _names = { "Daniel", "Vale", "Sebas" };

    // Ejemplo 3 [SerializedField]
    public GameObject[] _players;

    private void Start()
    {
        _numberArray[0] = 33;
        _numberArray[1] = 2;
        _numberArray[2] = 3;
        _numberArray[3] = 4;

        _players = GameObject.FindGameObjectsWithTag("Player");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _players = GameObject.FindGameObjectsWithTag("Enemy");
        }
    }
}
