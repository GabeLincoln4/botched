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
            if (_ingredientsBooleanValues._booleanValues[j] == false)
            {
                InstantiateGameObjectAtSpecifiedElement(ingredients._gameObjects[j]);
                ConfigureScale();
                SetInstantiatedGameObjectLocalScaleToScaledDownIndex();
                _instantiatedGameObject.localPosition = ConfigurePositionOfIngredientIndex(j);
                _ingredientsBooleanValues._booleanValues[j] = true;
            }
        }
    }

    private void InitializeIngredientIndexPosition()
    { _ingredientIndexPosition = Vector3.zero; }

    private void InstantiateGameObjectAtSpecifiedElement(Transform ingredientListGameObject)
    { _instantiatedGameObject = Instantiate(ingredientListGameObject); }

    private Vector3 ConfigurePositionOfIngredientIndex (int currentElement)
    {
        _ingredientIndexPosition.x = currentElement / _distanceFromNeighboringElement + _offset;
        _ingredientIndexPosition.z = _zPosition;
        _ingredientIndexPosition.y = _yPosition;

        return _ingredientIndexPosition;
    }

    private void ConfigureScale ()
    { _scaledDownIndex = Vector3.one / _scale; }

    private void SetInstantiatedGameObjectLocalScaleToScaledDownIndex()
    { _instantiatedGameObject.localScale = _scaledDownIndex; }
}
