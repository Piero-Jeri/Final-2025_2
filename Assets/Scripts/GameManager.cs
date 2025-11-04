using System;
using System.Timers;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Action SimpleEvent;
    public Action<int> Event2;

    void Start()
    {
    
    }d
    private void OnEnable()
    {
        Player.OnPlayerDead += ShowDeadUI;

    }
    private void OnDisable()
    {
        Player.OnPlayerDead -= ShowDeadUI;
    }

    public void ShowDeadUI()
    {

    }
}
