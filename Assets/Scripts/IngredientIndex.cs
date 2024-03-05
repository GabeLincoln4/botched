using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{
    Transform _currentIngredient;
    int _previousIndexSize = 0;
    
    Vector3 _position;

    void Update()
    {
        IncrementIngredientSlot(IngredientIndexManager.ingredients, IngredientIndexManager._wasIterated);
    }

    void IncrementIngredientSlot(List<Transform> ingredientsList, bool wasIterated) {

        if (ingredientsList.Count > _previousIndexSize && ingredientsList.Count < IngredientIndexManager._maxIndexSize + 1 && !wasIterated) {
            for (int i = 0; i < ingredientsList.Count; i++) {
                if (ingredientsList.ElementAt(i).GetComponent<IngredientSlot>().instantiated == true) {
                    Debug.Log("Already used");
                } else {
                    _currentIngredient = InstantiateIngredientSlotDomain(ingredientsList.ElementAt(i), ingredientsList, i);
                    ingredientsList[i] = _currentIngredient;
                }
            }
            IncrementMeasurementOfPreviousIndexSize(_previousIndexSize);
            IngredientIndexManager._wasIterated = true;
        }   
    }

    private int IncrementMeasurementOfPreviousIndexSize(int previousIndexSize) {
        return previousIndexSize++;
    }

    private Transform InstantiateIngredientSlotDomain(Transform currentIngredient, List<Transform> ingredients, int index) {
        currentIngredient = Instantiate(currentIngredient);
        _position.x = (index + 0.5f) + 2.75f;
        _position.y = 2f;
        currentIngredient.localPosition = _position;
        currentIngredient.GetComponent<IngredientSlot>().instantiated = true;
        return currentIngredient;
    }
}
