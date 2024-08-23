using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    [SerializeField] Image[] starobj = new Image[3];
    public Sprite clearStar;
    public Sprite nullStar;
    int finishscore = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        finishscore = GManager.instance.DragGameScore + GManager.instance.mixScore + GManager.instance.clickScore;

        if (finishscore <= 20)
        {
            starobj[0].sprite = nullStar;
            starobj[1].sprite = nullStar;
            starobj[2].sprite = nullStar;
        }
        else if (finishscore <= 40)
        {
            starobj[1].sprite = nullStar;
            starobj[2].sprite = nullStar;
        }
        else if (finishscore <= 50)
        {
            starobj[2].sprite = nullStar;
        }
    }
}
