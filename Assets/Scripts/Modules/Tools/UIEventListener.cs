using UnityEngine;
using UnityEngine.EventSystems;
using System;

namespace Summer
{
    /// <summary>
    /// 给UI组件添加事件
    /// </summary>
    public class UIEventListener : MonoBehaviour,
                                    IPointerClickHandler,
                                    IPointerDownHandler,
                                    IPointerEnterHandler,
                                    IPointerExitHandler,
                                    IPointerUpHandler,
                                    ISelectHandler,
                                    IUpdateSelectedHandler,
                                    IDeselectHandler,
                                    IDragHandler,
                                    IEndDragHandler,
                                    IDropHandler,
                                    IScrollHandler,
                                    IMoveHandler
    {
        //	public delegate void VoidDelegate (GameObject go);
        public Action<GameObject> OnClick;
        public Action<GameObject, PointerEventData> OnClickWithEventData;
        public Action<GameObject> OnDown;
        public Action<GameObject> OnEnter;
        public Action<GameObject> OnExit;
        public Action<GameObject> OnUp;
        public Action<GameObject> onSelect;
        public Action<GameObject> OnUpdateSelect;
        public Action<GameObject> OnDeSelect;
        public Action<GameObject, PointerEventData> onDrag;
        public Action<GameObject> OnDragEnd;
        public Action<GameObject> onDrop;
        public Action<GameObject, PointerEventData> onScroll;
        public Action<GameObject> onMove;

        public object _parameter;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (OnClick != null)
            {
                OnClick(gameObject);
            }
            if (OnClickWithEventData != null)
            {
                OnClickWithEventData(gameObject, eventData);
            }
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (OnDown != null)
            {
                OnDown(gameObject);
            }
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            if (OnEnter != null)
            {
                OnEnter(gameObject);
            }
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            if (OnExit != null)
            {
                OnExit(gameObject);
            }
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (OnUp != null)
            {
                OnUp(gameObject);
            }
        }

        public void OnSelect(BaseEventData eventData)
        {
            if (onSelect != null)
            {
                onSelect(gameObject);
            }
        }

        public void OnUpdateSelected(BaseEventData eventData)
        {
            if (OnUpdateSelect != null)
            {
                OnUpdateSelect(gameObject);
            }
        }

        public void OnDeselect(BaseEventData eventData)
        {
            if (OnDeSelect != null)
            {
                OnDeSelect(gameObject);
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            if (onDrag != null)
            {
                onDrag(gameObject, eventData);
            }
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            if (OnDragEnd != null)
            {
                OnDragEnd(gameObject);
            }
        }

        public void OnDrop(PointerEventData eventData)
        {
            if (onDrop != null)
            {
                onDrop(gameObject);
            }
        }

        public void OnScroll(PointerEventData eventData)
        {
            if (onScroll != null)
            {
                onScroll(gameObject, eventData);
            }
        }

        public void OnMove(AxisEventData eventData)
        {
            if (onMove != null)
            {
                onMove(gameObject);
            }
        }

        public static UIEventListener Get(GameObject go)
        {
            UIEventListener listener = go.GetComponent<UIEventListener>() ?? go.AddComponent<UIEventListener>();
            return listener;
        }
    }
}
