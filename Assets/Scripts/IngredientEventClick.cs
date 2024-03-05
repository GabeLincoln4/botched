using UnityEngine;
using UnityEngine.EventSystems;

public class IngredientEventClick : MonoBehaviour, IPointerClickHandler {

    [SerializeField]
    Transform ingredientSlot;

    public void OnPointerClick(PointerEventData eventData) {

        Debug.Log("Ingredient Clicked");
        IngredientIndexManager.AddIngredient(ingredientSlot);
        IngredientIndexManager.ToggleIterationStatus();
    }
}
