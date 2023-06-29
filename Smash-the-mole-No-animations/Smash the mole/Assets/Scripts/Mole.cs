using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    //Referencia al Animator
    [SerializeField]
    Animator moleAnimator;
    [SerializeField]
    ParticleSystem moleParticle;

    //Sube
    public void MoleOut()
    {
        //Hacer algo para activar esa animación
        //Entrar al animator, acceder a la variable topoArriba y modificar ese BOOL a false
        moleAnimator.SetBool("topoArriba", true);
    }

    //Baja
    public void MoleIn()
    {
        //Hacer algo para activar esa animación
        //Entrar al animator, acceder a la variable topoArriba y modificar ese BOOL a true
        moleAnimator.SetBool("topoArriba", false);
    }

    public void SmashMole()
    {
        MoleIn();
        moleParticle.Play();
        Events.EventSmashedMole(this);
    }
}
