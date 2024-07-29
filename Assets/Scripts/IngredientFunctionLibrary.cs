using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientFunctionLibrary : MonoBehaviour
{

    [SerializeField]
    private Transform _gameObject;

    public void AddGameObjectToList (ListVariableObject gameObjects)
    {
        gameObjects._gameObjects.Add(_gameObject);
    }
}
