using UnityEngine;
using UnityEngine.EventSystems;

public class TrashButtonEventClick : MonoBehaviour, IPointerClickHandler {

    public void OnPointerClick (PointerEventData eventData) {

        IngredientIndexManager.ClearIngredients();
    }
}