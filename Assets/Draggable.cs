using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private RectTransform rectTransform;
    private Vector2 offset;
    // private GameManager mg;
    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        offset = eventData.position - new Vector2(rectTransform.anchoredPosition.x, rectTransform.anchoredPosition.y);
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition = (eventData.position - offset) * 0.5f;
    }

    public void Close()
    {
        Destroy(this.gameObject);
    }
}
