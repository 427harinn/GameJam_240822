using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class knifemove : MonoBehaviour
{
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
        if(CutYasai.onClick)
        {
            this.transform.position = new Vector3(0, 0, 0);
        }
        else
        {
            this.transform.position = new Vector3(0, 1, 0);
        }

    }
}
