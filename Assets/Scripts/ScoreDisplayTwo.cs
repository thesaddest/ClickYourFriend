using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplayTwo : MonoBehaviour
{
	[SerializeField] private PlayerTwo _player;
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
