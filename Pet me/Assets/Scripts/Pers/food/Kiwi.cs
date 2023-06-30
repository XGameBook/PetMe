using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : Ihead
{
    public HpStat hpStat;
   
    public void life()
    {
        GameObject player3 = GameObject.FindWithTag("Îsnova");
        hpStat = player3.GetComponent<HpStat>();
        Debug.Log(hpStat.Head);
        Debug.Log("Kiwi ");

        hpStat.Head += 3;
        Debug.Log(hpStat.Head);
        if (hpStat.Head > 100)
        {
            hpStat.Head = 100;
        }
    }
}
