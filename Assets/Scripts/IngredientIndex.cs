using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{

    [SerializeField]
    private ListOfBooleanVariableObject _ingredientsBooleanValues;

    [SerializeField]
    private float _scale;

    [SerializeField]
    private float _offset;

    [SerializeField]
    private float _distanceFromNeighboringElement;

    [SerializeField]
    private float _yPosition;

    [SerializeField]
    private float _zPosition;

    private Vector3 _ingredientIndexPosition;
    private Transform _instantiatedGameObject;
    private Vector3 _scaledDownIndex;

    public void FillIngredientIndex (ListVariableObject ingredients)
    {
        InitializeIngredientIndexPosition();
        
        for (int j = 0; j < _ingredientsBooleanValues._booleanValues.Count; j++)
        {
            if (AssertThatBooleanValueAtSpecifiedElementIsEqualToFalse(j))
            {
                InstantiateGameObjectAtSpecifiedElement(ingredients._gameObjects[j]);
                ConfigureScale();
                SetInstantiatedGameObjectLocalScaleToScaledDownIndex();
                SetXPositionOfIngredientIndexBasedOnDesignerChosenOffsetAndDistanceFromNeighboringElement(j);
                SetYPositionOfIngredientIndexBasedOnDesignerInput();
                SetZPositionOfIngredientIndexBasedOnDesignerInput();
                SetInstantiatedGameObjectLocalPositionToConfiguredPositionOfIngredientIndex();
                SetBooleanVariableToTrueInIngredientsBooleanValuesList(j);
            }
        }
    }

    private void InitializeIngredientIndexPosition()
    { _ingredientIndexPosition = Vector3.zero; }

    private bool AssertThatBooleanValueAtSpecifiedElementIsEqualToFalse(int currentElement)
    { 
        if (_ingredientsBooleanValues._booleanValues[currentElement] == false)
        { return true; }
        else 
        { return false; }
    }

    private void InstantiateGameObjectAtSpecifiedElement(Transform ingredientListGameObject)
    { _instantiatedGameObject = Instantiate(ingredientListGameObject); }

    private void ConfigureScale ()
    { _scaledDownIndex = Vector3.one / _scale; }

    private void SetInstantiatedGameObjectLocalScaleToScaledDownIndex()
    { _instantiatedGameObject.localScale = _scaledDownIndex; }

    private void SetXPositionOfIngredientIndexBasedOnDesignerChosenOffsetAndDistanceFromNeighboringElement(int currentElement)
    { _ingredientIndexPosition.x = currentElement / _distanceFromNeighboringElement + _offset; }

    private void SetYPositionOfIngredientIndexBasedOnDesignerInput()
    { _ingredientIndexPosition.y = _yPosition; }

    private void SetZPositionOfIngredientIndexBasedOnDesignerInput()
    { _ingredientIndexPosition.z = _zPosition; }

    private void SetInstantiatedGameObjectLocalPositionToConfiguredPositionOfIngredientIndex ()
    { _instantiatedGameObject.localPosition = _ingredientIndexPosition; }

    private void SetBooleanVariableToTrueInIngredientsBooleanValuesList(int currentElement)
    { _ingredientsBooleanValues._booleanValues[currentElement] = true; }
}
