using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{
    int ingredientIndexLength;
    public bool wasInvoked;
    Transform currentIngredient;
    int previousIndexSize = 0;

    void Awake () {
        wasInvoked = false;
    }

    void Update()
    {
        IncrementIngredientSlot(IngredientIndexManager.ingredients);
    }

    void CheckIngredientIndexSize(List<Transform> ingredientsList) {
        if (ingredientsList.Count > 0 && !wasInvoked)  {
            Instantiate(ingredientsList.ElementAt(0));
            wasInvoked = true;
        } 
    }

    void IncrementIngredientSlot(List<Transform> ingredientsList) {

        if (ingredientsList.Count > previousIndexSize) {
            for (int i = 0; i < ingredientsList.Count; i++) {
                currentIngredient = Instantiate(ingredientsList.ElementAt(i));
                currentIngredient.GetComponent<IngredientSlot>().instantiated = true;
                ingredientsList[i] = currentIngredient;
            }
            Debug.Log(previousIndexSize);
            previousIndexSize++;
            Debug.Log(previousIndexSize);
            wasInvoked = true;
        }
        
    }
}
