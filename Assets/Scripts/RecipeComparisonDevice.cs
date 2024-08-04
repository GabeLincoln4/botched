using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecipeComparisonDevice : MonoBehaviour
{
    [SerializeField]
    private ListVariableObject _playerRecipe;

    [SerializeField]
    private ListVariableObject _predeterminedRecipe;

    public void CheckForMatchBetweenPredeterminedRecipeAndPlayerRecipe ()
    {
        for (int i = 0; i < _playerRecipe._gameObjects.Count; i++)
        {
            if (_playerRecipe._gameObjects[i] == _predeterminedRecipe._gameObjects[i])
            {
                Debug.Log("ingredient order matches for " + _playerRecipe._gameObjects[i].name + ".");
            }
            else
            {
                Debug.Log("order does not match");
            }
        }
    }
}