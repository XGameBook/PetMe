using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test22 : MonoBehaviour
{

    public Image Hpbar;


    // Start is called before the first frame update
    void Start()
    {


        GameObject player3 = GameObject.FindWithTag("1");
        Hpbar = player3.GetComponent<Image>();
        Hpbar.fillAmount = 0.5f;// Head / 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
