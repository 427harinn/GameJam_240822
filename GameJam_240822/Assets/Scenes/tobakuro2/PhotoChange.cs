using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoChange : MonoBehaviour
{
    private Image img;
    private int count = 1;

    void Start()
    {
        img = GameObject.Find("Image").GetComponent<Image>();
        img.sprite = Resources.Load<Sprite>("FinishImage/" + GManager.instance.select1 + "_" + GManager.instance.select2 + "_" + GManager.instance.select3);
    }

    public void Next()
    {
        count++;
        img.sprite = Resources.Load<Sprite>("FinishImage/" + GManager.instance.select1 + "_" + GManager.instance.select2 + "_" + GManager.instance.select3);
    }

    public void Back()
    {
        count--;
        if (count <= 0)
            count = 3;

        img.sprite = Resources.Load<Sprite>("Image/photo" + count.ToString());
    }
}
