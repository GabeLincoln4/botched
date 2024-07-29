using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour
{
    private void Update ()
    {
        if (Input.GetKeyDown("q"))
        {
            Debug.Log("q key has been pressed.");
        }
    }
}