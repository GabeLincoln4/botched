using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public static class IngredientIndexManager {

    public static List<Transform> ingredients = new List<Transform>();
    public static IngredientIndex ingredientIndex;
    public static bool _wasInvoked = true;
    public static bool _wasIterated = true;
    public static int _maxIndexSize = 4;
    public static int _minIndexSize = 0;

    public static void AddIngredient(Transform ingredient) {
        if (ingredients.Count < _maxIndexSize) {
            ingredients.Add(ingredient);
        }
        Debug.Log(ingredients.Count);
    }

    public static void ClearIngredients() {
        if (ingredients.Count <= _minIndexSize) {
            Debug.Log("Invalid button click");
        } else {
            for(int i = 0; i < ingredients.Count; i++) {
                
            }
            ingredients.Clear();
        }
    }

    public static void ToggleIterationStatus() {
        if (_wasIterated) {
            _wasIterated = false;
        } else {
            _wasIterated = true;
        }
    }

    

    public static void DeclareInstantiation() {
        for (int i = 0; i < ingredients.Count; i++) {
            ingredients.ElementAt(i).GetComponent<IngredientSlot>().instantiated = true;
        }
    }
}