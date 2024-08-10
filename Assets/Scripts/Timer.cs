using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private GameObject _timerGameObject;

    [SerializeField]
    private GameEvent _onTimerOff;

    [SerializeField]
    private FloatVariableObject _timerDurationInSeconds;

    [SerializeField]
    private float _customDuration;

    public void StartCurrentTimer ()
    {
        StartCoroutine(StartTimer());
    }

    private void RaiseTimerOffEvent ()
    {
        _onTimerOff.Raise();
    }

    IEnumerator StartTimer ()
    {
        _timerDurationInSeconds._floatValue = _customDuration;
        Debug.Log("Timer started");
        yield return new WaitForSeconds(_timerDurationInSeconds._floatValue);
        Debug.Log("Timer finished");
        _timerGameObject.GetComponent<Timer>().RaiseTimerOffEvent();
    }
}