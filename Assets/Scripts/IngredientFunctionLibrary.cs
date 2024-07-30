using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientFunctionLibrary : MonoBehaviour
{

    [SerializeField]
    private ListVariableObject _ingredients;

    public void AddGameObjectToList (Transform gameObject)
    {
        _ingredients._gameObjects.Add(gameObject);
    }

    private void OnDisable ()
    {
        _ingredients._gameObjects.Clear();
    }
}
