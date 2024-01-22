using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploListas : MonoBehaviour
{
    List<string> _nombres = new List<string>();

    private void Start()
    {
        _nombres.Add("Vale");
        _nombres.Add("Maria");
        _nombres.Add("Pablo");
        _nombres.Add("Nestor");

        _nombres.Remove("Vale");

        _nombres.Insert(1, "Sebastian");

        Debug.Log(_nombres[0]);
        Debug.Log(_nombres[1]);

    }
}
