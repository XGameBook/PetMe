using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class IPers : MonoBehaviour
{
    public float hp;
}

public interface Ihead
{
    public void life();
}

public interface IWeapons
{
    void Weapons();
}

public interface Ipet
{
    void pet();
}  