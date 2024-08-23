using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChangeScript : MonoBehaviour
{
    [SerializeField] Image baseImageobj;
    [SerializeField] Image[] foodImage = new Image[3];
    [SerializeField] Sprite[] baseImage = new Sprite[3];
    [SerializeField] Sprite[] topImage = new Sprite[9];
    // Start is called before the first frame update
    void Start()
    {
        if (GManager.instance.select1 == "cabbage")
        {
            baseImageobj.sprite = baseImage[0];
        }
        else if (GManager.instance.select1 == "onion")
        {
            baseImageobj.sprite = baseImage[1];
        }
        else
        {
            baseImageobj.sprite = baseImage[2];
        }


        if (GManager.instance.select3 == "tomato")
        {
            foodImage[0].sprite = topImage[0];
            foodImage[1].sprite = topImage[1];
            foodImage[2].sprite = topImage[2];
        }
        else if (GManager.instance.select3 == "cheese")
        {
            foodImage[0].sprite = topImage[3];
            foodImage[1].sprite = topImage[4];
            foodImage[2].sprite = topImage[5];
        }
        else
        {
            foodImage[0].sprite = topImage[6];
            foodImage[1].sprite = topImage[7];
            foodImage[2].sprite = topImage[8];
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
