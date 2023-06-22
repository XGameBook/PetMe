using UnityEngine;



/*

using Zenject;


public interface IWeapon
{
    void Shoot();
}

public class Gun : IWeapon
{
    public void Shoot()
    {

        Debug.Log("Bang! Bang!");
    }

}


public class goo : IWeapon
{
    public void Shoot()
    {

        Debug.Log("Bang! Bang!");
    }

}


public class Player
{
    private IWeapon weapon;

    public Player(IWeapon weapon)
    {
        this.weapon = weapon;
    }

    public void Attack()
    {
        weapon.Shoot();
    }
}

//public class GameInstaller : MonoInstaller
//{
  //  public override void InstallBindings()
  //  {
  //      Container.Bind<IWeapon>().To<Gun>().AsSingle();
   //     Container.Bind<Player>().AsSingle();
  //  }
//}

public class PlayerInputHandler : MonoBehaviour
{
    private Player player;

    [Inject]
    public void Construct(Player player)
    {
        this.player = player;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Attack();
        }
    }
}
*/
