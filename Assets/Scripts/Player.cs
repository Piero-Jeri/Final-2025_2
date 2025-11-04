using System;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Entity
{
    //-> Privados



    //->Actions
    public static Action OnPlayerDead;

    void Start()
    {
        PlayerDead();
    }

    void Update()
    {
        
    }

    public void PlayerDead()
    {
        OnPlayerDead?.Invoke();
    }

    public Vector3 GetPlayerPosition => gameObject.transform.position;
}
