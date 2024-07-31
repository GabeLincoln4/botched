using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class IngredientIndex : MonoBehaviour
{

    [SerializeField]
    private ListOfBooleanVariableObject _ingredientsBooleanValues;

    public void FillIngredientIndex (ListVariableObject ingredients)
    {
        Transform instantiatedGameObject;
        var position = Vector3.zero;
        
        for (int j = 0; j < _ingredientsBooleanValues._booleanValues.Count; j++)
        {
            if (_ingredientsBooleanValues._booleanValues[j] == false)
            {
                instantiatedGameObject = Instantiate(ingredients._gameObjects[j]);
                instantiatedGameObject.localScale = ConfigureScale(1.5f);
                instantiatedGameObject.localPosition = ConfigurePositionOfIngredientIndex(j, position, 3.25f, 1, 2, -3);
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
