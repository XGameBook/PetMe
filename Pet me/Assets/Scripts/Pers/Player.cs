using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class Plaeer1 : MonoBehaviour
{
    public Ihead h1;
    Plaeer1(Ihead h2)
    {
        h1 = h2;
    }
    public void realiz()
    {
        h1.life();
    }
}