using UnityEngine;
using UnityEngine.EventSystems;

public class IngredientEventClick : MonoBehaviour, IPointerClickHandler {

    [SerializeField]
    Transform ingredientSlot;

    public void OnPointerClick(PointerEventData eventData) {
        Instantiate(ingredientSlot);
    }
}
