using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public static class IngredientIndexManager {

    public static List<Transform> ingredients = new List<Transform>();

    public static void AddIngredient(Transform ingredient) {
        ingredients.Add(ingredient);
        Debug.Log(ingredients.Count);
    }

    public static void DeclareInstantiation() {
        for (int i = 0; i < ingredients.Count; i++) {
            ingredients.ElementAt(i).GetComponent<IngredientSlot>().instantiated = true;
        }
    }
}