using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleTester : MonoBehaviour
{
    public Mole[] moles; 
    private void Awake()
    {
        moles = FindObjectsOfType<Mole>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            for (int i = 0; i < moles.Length; i++)
            {
                moles[i].MoleOut();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < moles.Length; i++)
            {
                moles[i].MoleIn();
            }
        }
    }
}
