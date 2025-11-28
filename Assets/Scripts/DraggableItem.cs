using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Canvas canvas;
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;

    private void Awake()
    {
        canvas = GetComponentInParent<Canvas>(); // find the nearest canvas
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
       Debug.Log("OnBeginDrag");
       parentAfterDrag = transform.parent;
       transform.SetParent(canvas.transform);
       transform.SetAsLastSibling();
       image.raycastTarget = false;
    }
    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        transform.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
