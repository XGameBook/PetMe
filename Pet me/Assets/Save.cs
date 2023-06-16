using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public Osnova hp;

    public void saveHead()
    {
        PlayerPrefs.SetFloat("1", hp.Head);
        PlayerPrefs.Save();

    }

    public void loadHead()
    {
       // if (PlayerPrefs.HasKey("1"))
       // {
            hp.Head = PlayerPrefs.GetInt("1");
       // }
    }

}
