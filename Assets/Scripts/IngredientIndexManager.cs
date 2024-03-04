using UnityEngine;
using System.Collections.Generic;

public static class IngredientIndexManager {

    public static List<Transform> ingredients = new List<Transform>();

    public static void AddIngredient(Transform ingredient) {
        ingredients.Add(ingredient);
        Debug.Log(ingredients.Count);
    }
}