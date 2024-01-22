using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum TipoArma
{
    Espada,
    Arco,
    Lanza
}

public struct DatoArma
{
    public string nombre;
    public int daño;
    public TipoArma tipo;


    public DatoArma(string nombre, int daño, TipoArma tipo)
    {
        this.nombre = nombre;
        this.daño = daño;
        this.tipo = tipo;
    }

    public override string ToString()
    {
        return $"Nombre del arma: {nombre}, Daño: {daño}, Tipo: {tipo}" ;
    }
}

public class hola : MonoBehaviour
{
    DatoArma arma1 = new DatoArma("Espada de awa", 28, TipoArma.Espada);
    DatoArma arma2 = new DatoArma("Arco de awa", 30, TipoArma.Arco);
    DatoArma arma3 = new DatoArma("Lanza de awa", 25, TipoArma.Lanza);

    /*void Start()
    {
        Debug.Log(arma1);  
        Debug.Log(arma2);
        Debug.Log(arma3);
    } 
    */
    
}


