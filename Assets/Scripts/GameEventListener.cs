using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour 
{
    public GameEvent _gameEvent;
    public UnityEvent _response;

    public void OnEnable () 
    { _gameEvent.RegisterListener(this); }

    public void OnDisable () 
    { _gameEvent.UnregisterListener(this); }

    public void OnEventRaised () 
    { _response.Invoke(); }
}