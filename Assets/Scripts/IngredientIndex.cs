using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{
    int ingredientIndexLength;
    bool wasInvoked = false;


    void Update()
    {
        CheckIngredientIndexSize(IngredientIndexManager.ingredients);
    }

    void CheckIngredientIndexSize(List<Transform> ingredientsList) {
        if (ingredientsList.Count > 0 && !wasInvoked)  {
            Instantiate(ingredientsList.ElementAt(0));
            wasInvoked = true;
        } 
    }

    void IncrementIngredientSlot(List<Transform> ingredientsList) {

        Transform currentIngredient;
        for (int i = 0; i < ingredientsList.Count; i++) {
            Instantiate(ingredientsList.ElementAt(i));
        }
    }
}
