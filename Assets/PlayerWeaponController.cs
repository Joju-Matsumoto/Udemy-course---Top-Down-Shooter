using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GetComponent<Player>();
        player.controlls.Charactor.Fire.performed += context => Shoot();
    }

    private void Shoot()
    {
        GetComponentInChildren<Animator>().SetTrigger("Fire");
    }
}
