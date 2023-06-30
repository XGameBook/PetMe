using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class banana : Ihead
{
    public HpStat hpStat;
    public void life()
    {
        GameObject player3 = GameObject.FindWithTag("Îsnova");
        hpStat = player3.GetComponent<HpStat>();
        Debug.Log("banana");
        Debug.Log(hpStat.Head);
        hpStat.Head += 4;
        if (hpStat.Head > 100)
        {
            hpStat.Head = 100;
        }
    }
}

