using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClicked()
    {
        GManager.instance.DragGameScore = 0;
        GManager.instance.mixScore = 0;
        GManager.instance.clickScore = 0;
        SceneManager.LoadScene("StartScene");
    }
}
