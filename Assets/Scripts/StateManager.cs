using UnityEngine;

public class StateManager : MonoBehaviour {
    
    public static Transform[] ingredients = {}; 

    public static bool CheckIngredientSlot (Transform[] ingredients) {
        if (ingredients.Length == 4) {
            return true;   
        } else {
            return false;
        }
    }
}
