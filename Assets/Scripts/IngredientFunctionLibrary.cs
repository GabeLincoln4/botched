using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientFunctionLibrary : MonoBehaviour
{

    [SerializeField]
    private ListVariableObject _ingredients;

    [SerializeField]
    private ListOfBooleanVariableObject _listOfBooleanVariableObject;

    public void AddGameObjectToList (Transform gameObject)
    {
        _ingredients._gameObjects.Add(gameObject);
    }

    public void AddBooleanVariableToListObject ()
    {
        _listOfBooleanVariableObject._booleanValues.Add(false);
    }

    private void OnDisable ()
    {
        _ingredients._gameObjects.Clear();
        _listOfBooleanVariableObject._booleanValues.Clear();
    }
}
