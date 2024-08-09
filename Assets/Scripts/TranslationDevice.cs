using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslationDevice : MonoBehaviour
{

    [SerializeField]
    private Vector3 _lerpedValue;

    [SerializeField]
    private float _duration = 3;


    [SerializeField]
    private Vector3 _targetPosition;

    [SerializeField]
    private Transform _currentGameObject;

    private void OnEnable ()
    {
        StartCoroutine(LerpValue(_currentGameObject.position, _targetPosition));
    }

    // public void TranslateGameObject (Transform gameObject)
    // {
    //     float distance;


    // }

    IEnumerator LerpValue (Vector3 start, Vector3 end)
    {
        float timeElapsed = 0;

        while (timeElapsed < _duration)
        {
            float t = timeElapsed / _duration;

            t = t * t * (3f - 2f * t);

            _lerpedValue = Vector3.Lerp(start, end, t);
            _currentGameObject.position = _lerpedValue;
            timeElapsed += Time.deltaTime;

            yield return null;
        }

        _lerpedValue = end;
    }


}
