using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public int slotIndex;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
            draggableItem.parentAfterDrag = transform;

            // Save this card to PlayerPrefs
            PlayerPrefs.SetInt("DeckSlot_" + slotIndex, draggableItem.cardID);
            PlayerPrefs.Save();

            Debug.Log("Saved card " + draggableItem.cardID + " to slot " + slotIndex);
        }
    }
}

