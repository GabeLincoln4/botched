using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class OnStartGameEventRaiser : MonoBehaviour
{
    [SerializeField]
    private GameEvent _onStartGameEvent;

    public void Start()
    { _onStartGameEvent.Raise(); }
}