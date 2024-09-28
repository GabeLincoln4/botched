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
            { SetPredeterminedRecipeMatchTrackerElementToTrue(i);  }
            else if (AssertThatPlayerRecipeElementIsEqualToSecretRecipeElement(i))
            { SetSecretRecipeMatchTrackerElementToTrue(i); }
            else 
            { SetNotAMatchWithAnyRecipesToTrue(); }
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
    { return AssertThatPrimaryTransformIsEqualToSecondaryTransform(_playerRecipe._gameObjects[currentElement], _predeterminedRecipe._gameObjects[currentElement]); }

    private bool AssertThatPlayerRecipeElementIsEqualToSecretRecipeElement(int currentElement)
    { return AssertThatPrimaryTransformIsEqualToSecondaryTransform(_playerRecipe._gameObjects[currentElement], _secretRecipe._gameObjects[currentElement]); }

    private void SetNotAMatchWithAnyRecipesToFalse()
    { _notAMatchWithAnyRecipes = false; }

    private void SetNotAMatchWithAnyRecipesToTrue()
    { _notAMatchWithAnyRecipes = true; }

    private void SetPredeterminedRecipeMatchTrackerElementToTrue(int currentElement)
    { _predeterminedRecipeMatchTracker._booleanValues[currentElement] = true; }

    private void SetSecretRecipeMatchTrackerElementToTrue(int currentElement)
    { _secretRecipeMatchTracker._booleanValues[currentElement] = true; }

    private static bool isTrue(bool truthState) 
    { 
        return truthState == true; 
    } 

    private bool AssertThatPrimaryTransformIsEqualToSecondaryTransform(Transform primaryTransform, Transform secondaryTransform)
    { return ComparisonFunctionLibrary.AssertThatPrimaryTransformIsEqualToSecondaryTransform(primaryTransform, secondaryTransform); }
}