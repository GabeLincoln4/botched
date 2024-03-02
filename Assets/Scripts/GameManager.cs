using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool state;

    Transform[] ingredients;

    [SerializeField]
    GameObject[] managers = new GameObject[2];

    void Awake() {
        ingredients = new Transform[4];
        var cauldronManager = managers[1];
        cauldronManager.SetActive(false);
    }

    void Update() {
        state = StateManager.CheckIngredientSlot(ingredients);

        if (state) {
            Debug.Log("Slot is full");
            ingredients = new Transform[0];
        }
    }
}
