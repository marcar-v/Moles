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


    [SerializeField] AudioSource hitSound;

    public void PlayHitSound()
    {
        hitSound.Play();
    }

    public void MoleOut()
    {
        moleAnimator.SetBool("topoArriba", true);
    }

    public void MoleIn()
    {
        moleAnimator.SetBool("topoArriba", false);
    }

    public void SmashMole()
    {
        PlayHitSound();
        MoleIn();
        moleParticle.Play();
        Events.EventSmashedMole(this);
    }
}
