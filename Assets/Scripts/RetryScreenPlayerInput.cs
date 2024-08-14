using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class RetryScreenPlayerInput : MonoBehaviour
{
    private void Update ()
    {
        if (Input.GetKeyDown("q"))
        {
            Debug.Log("q pressed");          
        }

        if (Input.GetKeyDown("e"))
        {
            Debug.Log("e pressed");    
        }
    }
}