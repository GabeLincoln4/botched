using UnityEngine;
using UnityEngine.SceneManagement;

public class RecipeMatchResponder : MonoBehaviour 
{
    [SerializeField]
    private ListOfBooleanVariableObject _predeterminedRecipeBooleanList;
    [SerializeField]
    private ListOfBooleanVariableObject _secretRecipeBooleanList;

    public void InitiateRecipeMatchResponse()
    {
        if (_predeterminedRecipeBooleanList._booleanValues.Count == 0)
        { Debug.Log("botched... but not in a good way"); }
        else if (_predeterminedRecipeBooleanList._booleanValues.TrueForAll(isTrue))
        { Debug.Log("perfect...."); }
        else if (_secretRecipeBooleanList._booleanValues.TrueForAll(isTrue))
        { Debug.Log("Botched!"); }
        else
        { Debug.Log("botched... but not in a good way"); }
    }

    private static bool isTrue(bool truthState) 
    { 
        return truthState == true; 
    } 
}