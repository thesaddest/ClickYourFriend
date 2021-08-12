using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
	[SerializeField] private Slider _slider;

	private void Start()
	{
		SetHealth(50);
	}
	public void SetHealth(int health)
	{
		_slider.value = health;
	}
}
