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

    [SerializeField]
    private GameEvent _onSpaceKeyPressed;

    [SerializeField]
    private GameEvent _onInputPressed;

    private void Update ()
    {
        if (Input.GetKeyDown("q"))
        {
            _onQKeyPressed.Raise();
            _onInputPressed.Raise();           
        }

        if (Input.GetKeyDown("w"))
        {
            _onWKeyPressed.Raise();
            _onInputPressed.Raise();
        }

        if (Input.GetKeyDown("a"))
        {
            _onAKeyPressed.Raise();
            _onInputPressed.Raise();
        }

        if (Input.GetKeyDown("s"))
        {
            _onSKeyPressed.Raise();
            _onInputPressed.Raise();
        }

        if (Input.GetKeyDown("space"))
        {
            _onSpaceKeyPressed.Raise();
        }
    }
}