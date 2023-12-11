using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;

    public void instantiate()
    {
        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            float minutes = Mathf.FloorToInt(scores[i].score / 60);
            float seconds = Mathf.FloorToInt(scores[i].score % 60);
            row.score.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}