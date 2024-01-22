using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    List<string> _inventario = new List<string>();

    private void Start()
    {
        _inventario.Add("Awa");
        _inventario.Add("Sopa de hongo");
        _inventario.Add("Cuchillo");
        _inventario.Add("Arco");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(_inventario[0]);
            Debug.Log(_inventario[1]);
            Debug.Log(_inventario[2]);
            Debug.Log(_inventario[3]);
        }

    }
}
