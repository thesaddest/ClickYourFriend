using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class ClickerZone : MonoBehaviour, IPointerClickHandler      
{
	public event UnityAction Click;
	void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
	{
		Click?.Invoke();
	}
}
