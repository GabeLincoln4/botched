using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{

    [SerializeField]
    private GameEvent _onQKeyPressed;

    [SerializeField]
    private GameEvent _onWKeyPressed;

    [SerializeField]
    private GameEvent _onAKeyPressed;

    [SerializeField]
    private GameEvent _onSKeyPressed;

    private void Update ()
    {
        if (Input.GetKeyDown("q"))
        {
            _onQKeyPressed.Raise();
        }

        if (Input.GetKeyDown("w"))
        {
            _onWKeyPressed.Raise();
        }

        if (Input.GetKeyDown("a"))
        {
            _onAKeyPressed.Raise();
        }

        if (Input.GetKeyDown("s"))
        {
            _onSKeyPressed.Raise();
        }
    }
}