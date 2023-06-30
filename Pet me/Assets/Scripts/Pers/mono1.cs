using UnityEngine;
using Zenject;

public class mono1 : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Ihead>().To<apple>().AsSingle();
        Container.Bind<Ihead>().To<Kiwi>().AsSingle();
        Container.Bind<Ihead>().To<banana>().AsSingle();
        Container.Bind<Plaeer1>().AsSingle();

      //  Container.Bind<Ihead>().To<HeadFilled>().AsSingle();
      //  Container.Bind<Ibar>().To<HeadFilled>().AsSingle();
    }
}




