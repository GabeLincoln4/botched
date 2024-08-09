using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientFunctionLibrary : MonoBehaviour
{

    [SerializeField]
    private ListVariableObject _ingredients;

    [SerializeField]
    private ListOfBooleanVariableObject _listOfBooleanVariableObject;

    [SerializeField]
    private GameEvent _onTrueVariable;

    [SerializeField]
    private GameEvent _onFalseVariable;

    public void AddGameObjectToList (Transform gameObject)
    {
        _ingredients._gameObjects.Add(gameObject);
    }

    public void AddBooleanVariableToListObject ()
    {
        _listOfBooleanVariableObject._booleanValues.Add(false);
    }

    public void CheckForBooleanState (BooleanVariableObject booleanVariableObject)
    {
        if (booleanVariableObject._booleanValue == true)
        {
            _onTrueVariable.Raise();
        }
        else 
        {
            _onFalseVariable.Raise();
        }
    }

    public void DebugValue ()
    {
        Debug.Log("value is true");
    }

    private void OnDisable ()
    {
        _ingredients._gameObjects.Clear();
        _listOfBooleanVariableObject._booleanValues.Clear();
    }
}
