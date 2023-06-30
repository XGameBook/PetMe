using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEngine.UI;
public class HpStat : MonoBehaviour
{

    public float Head = 50;
    public Image Hpbar;
    public void h()
    {
        GameObject player3 = GameObject.FindWithTag("1");
        Hpbar = player3.GetComponent<Image>();
        Hpbar.fillAmount = Head / 100;
        Debug.Log(Head);
    }
    private void Update()
    {
        h();
    }
}