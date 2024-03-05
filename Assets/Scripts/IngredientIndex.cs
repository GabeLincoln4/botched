using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{
    int ingredientIndexLength;
    public bool wasInvoked;
    Transform currentIngredient;
    int _previousIndexSize = 0;
    Vector3 position;

    void Awake () {
        wasInvoked = false;
    }

    void Update()
    {
        IncrementIngredientSlot(IngredientIndexManager.ingredients, IngredientIndexManager._wasIterated);
    }

    void CheckIngredientIndexSize(List<Transform> ingredientsList) {
        if (ingredientsList.Count > 0 && !wasInvoked)  {
            Instantiate(ingredientsList.ElementAt(0));
            wasInvoked = true;
        } 
    }

    void IncrementIngredientSlot(List<Transform> ingredientsList, bool wasIterated) {

        if (ingredientsList.Count > _previousIndexSize && !wasIterated) {
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
            IncrementMeasurementOfPreviousIndexSize(_previousIndexSize);
            IngredientIndexManager._wasIterated = true;
            wasInvoked = true;
        }   
    }
    private int IncrementMeasurementOfPreviousIndexSize(int previousIndexSize) {
        return previousIndexSize++;
    }
}
