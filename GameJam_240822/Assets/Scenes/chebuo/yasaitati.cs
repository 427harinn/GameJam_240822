using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yasaitati : MonoBehaviour
{
    [SerializeField] private Image yasai;
    public Sprite[] yasais;
    [SerializeField] private Image yasaicut;
    public Sprite[] yasaiscut;
    private int click = 0;
    cutyasai CutYasai;
    // Start is called before the first frame update
    void Start()
    {
        CutYasai = GetComponent<cutyasai>();
        GameObject obj = GameObject.Find("Renda");
        CutYasai = obj.GetComponent<cutyasai>();
    }

    // Update is called once per frame
    void Update()
    {
        click = CutYasai.mouseclick;
        Debug.Log(click);
        if (CutYasai.mouseclick >= 0 && CutYasai.mouseclick < 20)
        {
            GManager.instance.clickScore = 10;
            yasai.sprite = yasais[0];
            if (CutYasai.onClick)
            {
                yasaicut.sprite = yasaiscut[0];
            }
        }
        if (CutYasai.mouseclick >= 20 && CutYasai.mouseclick < 40)
        {
            GManager.instance.clickScore = 20;
            yasai.sprite = yasais[1];
            if (CutYasai.onClick)
            {
                yasaicut.sprite = yasaiscut[1];
            }
        }
        if (click >= 40)
        {
            GManager.instance.clickScore = 30;
            yasai.sprite = yasais[2];
            if (CutYasai.onClick)
            {
                yasaicut.sprite = yasaiscut[2];
            }
        }
    }
}
