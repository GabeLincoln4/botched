using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool state;

    Transform[] ingredients;

    void Awake() {
        ingredients = new Transform[4];
    }

    void Update() {
        state = StateManager.CheckIngredientSlot(ingredients);

        if (state) {
            Debug.Log("Slot is full");
            ingredients = new Transform[0];
        }
    }
}
