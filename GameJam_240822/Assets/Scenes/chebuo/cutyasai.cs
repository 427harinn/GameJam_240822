using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using KanKikuchi.AudioManager;

public class cutyasai : MonoBehaviour
{
    //public int maxmouseclick = 10;
    public int mouseclick = 0;
    public bool onClick;
    // Start is called before the first frame update
    void Start()
    {
        //timetext = GetComponent<text>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        mouseclick++;
        Debug.Log(mouseclick);
    }
    public void OnButtonDown()
    {
        Debug.Log("‰Ÿ‚³‚ê‚Ä‚é");
        SEManager.Instance.Play(SEPath.CUTTING);
        onClick = true;
    }
    public void OnButtonUp()
    {
        Debug.Log("—£‚³‚ê‚½");
        onClick = false;
    }
}



