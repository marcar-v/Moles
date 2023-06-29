using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{

    Ray ray;
    RaycastHit rayInfo;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out rayInfo))
            {
                Debug.Log("Rayo ha golpeado a: " + rayInfo.collider.name);

                if(rayInfo.collider.GetComponent<Mole>() != null)
                {
                    Mole moleSmashed =  rayInfo.collider.GetComponent<Mole>();
                    moleSmashed.SmashMole();
                }
            }
        }
    }
}
