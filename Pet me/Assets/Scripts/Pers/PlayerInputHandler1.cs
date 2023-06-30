using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using UnityEngine.UI;
public class PlayerInputHandler1 : MonoBehaviour
{
    public Plaeer1 player;
    public Ihead[] iheads;
    public int numberFood = 0;


    public Image Hpbar;
 

    [Inject]
    public void Construct(Plaeer1 player, Ihead[] iheads)
    {

        this.player = player;
        this.iheads = iheads;
    }



   // public void Update()
  //  {
      //  Ihead currentWeapon = iheads[3];
     //   player.Food(currentWeapon);
      //  player.realiz();
       
   // }



    public void OnMouseUp()
    {
        Ihead currentWeapon = iheads[numberFood];
        player.Food(currentWeapon);
        player.realiz();
    }



}


