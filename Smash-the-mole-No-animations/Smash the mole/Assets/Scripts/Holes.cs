using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holes : MonoBehaviour
{
    [SerializeField] Mole[] moles;
    [SerializeField] float waitingTime = 1.5f;
    [SerializeField] float repeatingTime = 2.0f;
    [SerializeField] float startingTime = 1.0f;

    private void Start()
    {
        moles = FindObjectsOfType<Mole>();
    }

    public void StartHole()
    {
        InvokeRepeating("UpRandomMole", startingTime, repeatingTime);
    }

    private void UpRandomMole()
    {
        StartCoroutine(UpRandomMoleRoutine());
    }

    public void EndHole()
    {
        CancelInvoke();
    }
    IEnumerator UpRandomMoleRoutine()
    {
        int indexRandomMole = Random.Range(0, moles.Length);

        Mole choosenMole = moles[indexRandomMole];
        choosenMole.MoleOut();
        yield return new WaitForSeconds(waitingTime);
        choosenMole.MoleIn();

    }
}
