using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerControlls controlls;

    private void Awake()
    {
        controlls = new PlayerControlls();
    }


    private void OnEnable()
    {
        controlls.Enable();
    }

    private void OnDisable()
    {
        controlls.Disable();
    }
}
