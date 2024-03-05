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
    Vector3 position;

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
                if (ingredientsList.ElementAt(i).GetComponent<IngredientSlot>().instantiated == true) {
                    Debug.Log("Already used");
                } else {
                    currentIngredient = Instantiate(ingredientsList.ElementAt(i));
                    position.x = (i + 0.5f) + 2.75f;
                    position.y = 2f;
                    currentIngredient.localPosition = position;
                    currentIngredient.GetComponent<IngredientSlot>().instantiated = true;
                    ingredientsList[i] = currentIngredient;
                }
                
            }
            Debug.Log(previousIndexSize);
            previousIndexSize++;
            Debug.Log(previousIndexSize);
            wasInvoked = true;
        }
        
    }
}
