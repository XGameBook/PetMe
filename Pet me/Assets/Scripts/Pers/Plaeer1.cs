using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class Plaeer1 
{
    public Ihead h1;
    public void Food(Ihead h1)
    {
        this.h1 = h1;
    }
    public void realiz()
    {
        h1.life();  
    }
}