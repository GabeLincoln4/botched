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

    public void CheckForMatchBetweenPredeterminedRecipeAndPlayerRecipe ()
    {
        bool notAMatchWithPredeterminedRecipe = false;
        bool notAMatchWithSecretRecipe = false;
        bool notAMatchWithAnyRecipes = false;
        for (int i = 0; i < _playerRecipe._gameObjects.Count; i++)
        {
            _functionLibrary.AddBooleanVariableToListObject(_predeterminedRecipeMatchTracker);
            _functionLibrary.AddBooleanVariableToListObject(_secretRecipeMatchTracker);

            if (_playerRecipe._gameObjects[i] == _predeterminedRecipe._gameObjects[i])
            { _predeterminedRecipeMatchTracker._booleanValues[i] = true;  }
            else if (_playerRecipe._gameObjects[i] == _secretRecipe._gameObjects[i])
            { _secretRecipeMatchTracker._booleanValues[i] = true; }
            else 
            { notAMatchWithAnyRecipes = true; }
        }



        if (_predeterminedRecipeMatchTracker._booleanValues.TrueForAll(isTrue))
        { Debug.Log("perfect...."); }
        else if (_secretRecipeMatchTracker._booleanValues.TrueForAll(isTrue))
        { Debug.Log("Botched!"); }
        else
        { Debug.Log("botched... but not in a good way"); }
    }

    private static bool isTrue(bool truthState) 
    { 
        return truthState == true; 
    } 
}