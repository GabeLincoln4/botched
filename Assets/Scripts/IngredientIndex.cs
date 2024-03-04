using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{
    [SerializeField]
    Transform ingredientSlot;
    int ingredientIndexLength;
    bool alreadyChecked;

    void Awake () {
        ingredientIndexLength = IngredientIndexManager.ingredients.Count;
        alreadyChecked = false;
    }

    void Update()
    {
        if (IngredientIndexManager.ingredients.Count > 0 && !alreadyChecked) {
            Debug.Log("Slot instantiated");
            alreadyChecked = true;
            Instantiate(IngredientIndexManager.ingredients.ElementAt(0));
        }
    }
}
