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

    public void CheckForMatchBetweenPredeterminedRecipeAndPlayerRecipe ()
    {
        bool notAMatch = false;
        for (int i = 0; i < _playerRecipe._gameObjects.Count; i++)
        {
            if (_playerRecipe._gameObjects[i] != _predeterminedRecipe._gameObjects[i])
            { notAMatch = true; }
        }

        if (notAMatch)
        { Debug.Log("botched... but not in a good way"); }
        else 
        { Debug.Log("perfect...."); }
    }
}