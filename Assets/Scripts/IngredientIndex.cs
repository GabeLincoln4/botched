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

    public void FillIngredientIndex (ListVariableObject ingredients)
    {
        Transform instantiatedGameObject;
        _ingredientIndexPosition = Vector3.zero;
        
        for (int j = 0; j < _ingredientsBooleanValues._booleanValues.Count; j++)
        {
            if (_ingredientsBooleanValues._booleanValues[j] == false)
            {
                instantiatedGameObject = Instantiate(ingredients._gameObjects[j]);
                instantiatedGameObject.localScale = ConfigureScale(_scale);
                instantiatedGameObject.localPosition = ConfigurePositionOfIngredientIndex(j, _ingredientIndexPosition, _offset, _distanceFromNeighboringElement, _yPosition, _zPosition);
                _ingredientsBooleanValues._booleanValues[j] = true;
            }
        }
    }

    private Vector3 ConfigurePositionOfIngredientIndex (int currentElement, Vector3 position, float offset, float distanceFromNeighboringElement, float yPosition, float zPosition)
    {
        position.x = currentElement / distanceFromNeighboringElement + offset;
        position.z = zPosition;
        position.y = yPosition;

        return position;
    }

    private Vector3 ConfigureScale (float scale)
    { return Vector3.one / scale; }
}
