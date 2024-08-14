using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RetryScreenPlayerInput : MonoBehaviour
{

    [SerializeField]
    private GameEvent _onQKeyHeldDown, _onQKeyPressed, _onQKeyUp, _onEKeyHeldDown, _onEKeyPressed, _onEKeyUp;


    private void Update ()
    {
        if (Input.GetKeyDown("q"))
        {
            _onQKeyPressed.Raise();
        }

        if (Input.GetKeyUp("q"))
        {
            _onQKeyUp.Raise();
        }

        if (Input.GetKey("q"))
        {
            _onQKeyHeldDown.Raise();
        }

        if (Input.GetKeyDown("e"))
        {
            _onEKeyPressed.Raise();    
        }

        if (Input.GetKey("e"))
        {
            _onEKeyHeldDown.Raise();    
        }

        if (Input.GetKeyUp("e"))
        {
            _onEKeyUp.Raise();    
        }
    }
}