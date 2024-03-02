using UnityEngine;

public class StateManager : MonoBehaviour {
    
    static Transform[] ingredients = {}; 

    public static bool CheckIngredientSlot (Transform[] ingredients) {
        if (ingredients.Length == 4) {
            return true;   
        } else {
            return false;
        }
    }
}
