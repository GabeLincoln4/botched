using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientFunctionLibrary : MonoBehaviour
{

    [SerializeField]
    private Transform _gameObject;

    private List<Transform> _ingredients;

    public void AddGameObjectToList (ListVariableObject gameObjects)
    {
        _ingredients = gameObjects._gameObjects;

        _ingredients.Add(_gameObject);
    }

    private void OnDisable ()
    {
        _ingredients.Clear();
    }
}
