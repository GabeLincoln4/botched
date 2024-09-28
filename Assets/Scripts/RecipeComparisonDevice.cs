using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class RecipeComparisonDevice : MonoBehaviour
{
    [SerializeField]
    private ListVariableObject _playerRecipe;

    [SerializeField]
    private ListVariableObject _predeterminedRecipe;

    [SerializeField]
    private ListVariableObject _secretRecipe;

    [SerializeField]
    private ListOfBooleanVariableObject _predeterminedRecipeMatchTracker;

    [SerializeField]
    private ListOfBooleanVariableObject _secretRecipeMatchTracker;

    [SerializeField]
    private IngredientFunctionLibrary _functionLibrary;

    private bool _notAMatchWithAnyRecipes;

    public void CheckForMatchBetweenPredeterminedRecipeAndPlayerRecipe ()
    {
        SetNotAMatchWithAnyRecipesToFalse();
        for (int i = 0; i < _playerRecipe._gameObjects.Count; i++)
        {
            AddABooleanVariableToThePredeterminedRecipeMatchTracker();
            AddABooleanVariableToTheSecretRecipeMatchTracker();

            if (AssertThatPlayerRecipeElementIsEqualToPredeterminedRecipeElement(i))
            { _predeterminedRecipeMatchTracker._booleanValues[i] = true;  }
            else if (_playerRecipe._gameObjects[i] == _secretRecipe._gameObjects[i])
            { _secretRecipeMatchTracker._booleanValues[i] = true; }
            else 
            { _notAMatchWithAnyRecipes = true; }
        }


        if (_predeterminedRecipeMatchTracker._booleanValues.Count == 0)
        { Debug.Log("botched... but not in a good way"); }
        else if (_predeterminedRecipeMatchTracker._booleanValues.TrueForAll(isTrue))
        { Debug.Log("perfect...."); }
        else if (_secretRecipeMatchTracker._booleanValues.TrueForAll(isTrue))
        { Debug.Log("Botched!"); }
        else
        { Debug.Log("botched... but not in a good way"); }
    }

    private void AddABooleanVariableToThePredeterminedRecipeMatchTracker()
    { _functionLibrary.AddBooleanVariableToListObject(_predeterminedRecipeMatchTracker); }

    private void AddABooleanVariableToTheSecretRecipeMatchTracker()
    { _functionLibrary.AddBooleanVariableToListObject(_secretRecipeMatchTracker); }

    private bool AssertThatPlayerRecipeElementIsEqualToPredeterminedRecipeElement(int currentElement)
    { 
        if (_playerRecipe._gameObjects[currentElement] == _predeterminedRecipe._gameObjects[currentElement])
        { return true; }
        else 
        { return false; }
    }

    private void SetNotAMatchWithAnyRecipesToFalse()
    { _notAMatchWithAnyRecipes = false; }

    private static bool isTrue(bool truthState) 
    { 
        return truthState == true; 
    } 
}