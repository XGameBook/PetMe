using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        //   Container.Bind<Ihead>().To<apple>().AsSingle();

        //Container.Bind<IWeapon>().To<Gun>().AsSingle();
        //Container.Bind<Player>().AsSingle();
        Container.Bind<Ihead>().To<apple>().AsSingle();
        Container.Bind<Ihead>().To<banana>().AsSingle();
        Container.Bind<Plaeer1>().AsSingle();
    }
}


public class PlayerInputHandler1 : MonoBehaviour
{
    private Plaeer1 player;

    [Inject]
    public void Construct(Plaeer1 player)
    {
        this.player = player;
    }

    public void OnMouseUp()
    {
        player.realiz();
    }

}