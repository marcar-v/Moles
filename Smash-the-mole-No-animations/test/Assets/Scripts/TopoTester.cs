using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopoTester : MonoBehaviour
{
    public Topo[] topos; 
    private void Awake()
    {
        topos = FindObjectsOfType<Topo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            for (int i = 0; i < topos.Length; i++)
            {
                topos[i].Salir();
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            for (int i = 0; i < topos.Length; i++)
            {
                topos[i].Entrar();
            }
        }
    }
}
