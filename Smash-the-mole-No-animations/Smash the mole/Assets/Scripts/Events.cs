using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  static class Events
{
    public static event Action<Mole> SmashedMole = delegate { };

    public static void EventSmashedMole(Mole mole)
    {
        Debug.Log("Topo golpeado se dispara:" + mole.name);
        SmashedMole(mole);
    }

    public static event Action TimeOver = delegate { };

    public static void EventTimeOver()
    {
        TimeOver();
    }
}
