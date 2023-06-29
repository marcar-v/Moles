using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topo : MonoBehaviour
{
    //Referencia al Animator
    public Animator animatorDelTopo;

    //Sube
    public void Salir()
    {
        //Hacer algo para activar esa animación
        //Entrar al animator, acceder a la variable topoArriba y modificar ese BOOL a false
        animatorDelTopo.SetBool("topoArriba", true);
    }

    //Baja
    public void Entrar()
    {
        //Hacer algo para activar esa animación
        //Entrar al animator, acceder a la variable topoArriba y modificar ese BOOL a true
        animatorDelTopo.SetBool("topoArriba", false);
    }

    //Golpeas TO-DO
}
