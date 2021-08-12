using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayOne : MonoBehaviour
{
	[SerializeField] private PlayerOne _player;
	[SerializeField] private TMP_Text _scoreDisplayText;

	private void OnEnable()
	{
		_player.ScoreChanged += OnScoreChanged;
	}

	private void OnDisable()
	{
		_player.ScoreChanged -= OnScoreChanged;
	}

	private void OnScoreChanged(int score)
	{
		_scoreDisplayText.text = score.ToString();
	}
}
