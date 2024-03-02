using UnityEngine;

public static class StateManager {
    
    static Transform[] ingredients = {}; 

    public static bool CheckIngredientSlot (Transform[] ingredients) {
        if (ingredients.Length == 4) {
            return true;   
        } else {
            return false;
        }
    }
}
