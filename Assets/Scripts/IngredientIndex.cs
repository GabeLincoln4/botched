using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{

    [SerializeField]
    private ListOfBooleanVariableObject _ingredientsBooleanValues;
    Transform _currentIngredient;
    int _previousIndexSize = 0;
    
    Vector3 _position;

    void Update()
    {
        IncrementIngredientSlot(IngredientIndexManager.ingredients, IngredientIndexManager._wasIterated);
    }

    private void OnDisable ()
    {
        _ingredientsBooleanValues._booleanValues.Clear();
    }

    void IncrementIngredientSlot(List<Transform> ingredientsList, bool wasIterated) {

        if (ingredientsList.Count > _previousIndexSize && ingredientsList.Count < IngredientIndexManager._maxIndexSize + 1 && !wasIterated) {
            for (int i = 0; i < ingredientsList.Count; i++) {
                if (ingredientsList.ElementAt(i).GetComponent<IngredientSlot>()._instantiated == true) {
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
        currentIngredient.GetComponent<IngredientSlot>()._instantiated = true;
        return currentIngredient;
    }

    public void FillIngredientIndex (ListVariableObject ingredients)
    {
        Transform instantiatedGameObject;
        _ingredientsBooleanValues._booleanValues.Add(false);
        
        for (int j = 0; j < _ingredientsBooleanValues._booleanValues.Count; j++)
        {
            if (_ingredientsBooleanValues._booleanValues[j] == false)
            {
                Instantiate(ingredients._gameObjects[j]);
                Debug.Log("ingredient boolean was orignally false but is now true.");
                _ingredientsBooleanValues._booleanValues[j] = true;
            }
            else
            { Debug.Log("ingredient boolean is true"); }
        }
    }
}
