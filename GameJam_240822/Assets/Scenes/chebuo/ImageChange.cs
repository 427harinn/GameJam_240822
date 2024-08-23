using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class ImageChange : MonoBehaviour
{
    [SerializeField] GameObject[] food = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        if (GManager.instance.select1 == "cabbage")
        {
            food[0].SetActive(true);
        }
        else if (GManager.instance.select1 == "onion")
        {
            food[1].SetActive(true);
        }
        else
        {
            food[2].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
