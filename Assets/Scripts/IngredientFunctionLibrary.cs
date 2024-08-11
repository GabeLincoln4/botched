using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientFunctionLibrary : MonoBehaviour
{

    [SerializeField]
    private ListVariableObject _ingredients;

    [SerializeField]
    private ListOfBooleanVariableObject _listOfBooleanVariablesForPredeterminedRecipeDisplay;

    [SerializeField]
    private ListOfBooleanVariableObject _listOfBooleanVariableObject;

    [SerializeField] 
    private ListOfBooleanVariableObject _predeterminedRecipeMatchTracker;

    [SerializeField]
    private ListOfBooleanVariableObject _secretRecipeMatchTracker;

    [SerializeField]
    private GameEvent _onTrueVariable;

    [SerializeField]
    private GameEvent _onFalseVariable;

    [SerializeField]
    private BooleanVariableObject _grimoireActivationState;

    public void AddGameObjectToList (Transform gameObject)
    {
        _ingredients._gameObjects.Add(gameObject);
    }

    public void AddBooleanVariableToListObject ()
    {
        _listOfBooleanVariableObject._booleanValues.Add(false);
    }

    public void AddBooleanVariableToListObject (ListOfBooleanVariableObject booleanList)
    {
        booleanList._booleanValues.Add(false);
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
        _predeterminedRecipeMatchTracker._booleanValues.Clear();
        _secretRecipeMatchTracker._booleanValues.Clear();
        _grimoireActivationState._booleanValue = true;
        SetAllBooleanValuesInAListToFalse(_listOfBooleanVariablesForPredeterminedRecipeDisplay);
    }

    private void SetAllBooleanValuesInAListToFalse (ListOfBooleanVariableObject booleanList)
    {
        for (int i = 0; i < booleanList._booleanValues.Count; i++)
        {
            booleanList._booleanValues[i] = false;
        }
    }
}
