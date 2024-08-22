using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class yasaitati : MonoBehaviour
{
    [SerializeField]private Image yasai;
    public Sprite[] yasais;
    private int click = 0;
    cutyasai CutYasai;
    // Start is called before the first frame update
    void Start()
    {
        CutYasai = GetComponent<cutyasai>();
        GameObject obj = GameObject.Find("˜A‘Å");
        CutYasai = obj.GetComponent<cutyasai>();
    }

    // Update is called once per frame
    void Update()
    {
        click=CutYasai.mouseclick;
        Debug.Log(click);
        if (click >= 0 && click < 20)
        {
            yasai.sprite=yasais[0];
        }
        if (click >= 20 && click < 50)
        {
            yasai.sprite=yasais[1];
        }
        if (click >= 50)
        {
            yasai.sprite=yasais[2];
        }
    }
}
