using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Zenject;

public class apple : Ihead
{
    public HpStat hpStat;
    public void life()
    {
        GameObject player3 = GameObject.FindWithTag("Îsnova");
        hpStat = player3.GetComponent<HpStat>();

        Debug.Log("apple");
        Debug.Log(hpStat.Head);
        hpStat.Head += 2;
        if (hpStat.Head > 100)
        {
            hpStat.Head = 100;
        }
    }
}
