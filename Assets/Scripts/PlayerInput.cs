using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{

    [SerializeField]
    private GameEvent _onQKeyPressed;

    private void Update ()
    {
        if (Input.GetKeyDown("q"))
        {
            _onQKeyPressed.Raise();
        }
    }
}