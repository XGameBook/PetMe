using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Osnova : MonoBehaviour
{    public float Head= 1;
    public float Time1;
 

    // Start is called before the first frame update
    void Start()
    {
        Head= 0;
    }

    // Update is called once per frame
    void Update()
    {
        Time1 += Time.deltaTime;
    }
}
