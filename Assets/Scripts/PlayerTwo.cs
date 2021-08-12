using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerTwo : MonoBehaviour
{
	[SerializeField] private ClickerZone _clickerZone;
	[SerializeField] private Slider _slider;

	private int _clickCount;

	public event UnityAction<int> ScoreChanged;

	private void OnEnable()
	{
		_clickerZone.Click += OnClick;
	}

	private void OnDisable()
	{
		_clickerZone.Click -= OnClick;
	}

	private void OnClick()
	{
		_clickCount++;
		ScoreChanged?.Invoke(_clickCount);
		DealDamage(5);
	}

	private void DealDamage(int damage)
	{
		_slider.value += damage;
	}
}
