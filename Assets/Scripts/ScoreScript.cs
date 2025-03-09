using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI MyScoreUI;
    public int MyScoreAmount;

    void Start()
    {
        MyScoreUI = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        //AddToScore();
    }

    public void AddToScore()
    {
        MyScoreAmount = MyScoreAmount + 1;
        MyScoreUI.text = MyScoreAmount.ToString();
    }
}
