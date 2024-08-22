using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Text text;
    private int totalScoreUI;
    public int TotalScoreUI
    {
        get { return totalScoreUI; }
        set { totalScoreUI = value; text.text = totalScoreUI.ToString(); }
    }
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score: " + totalScoreUI);
    }
}
