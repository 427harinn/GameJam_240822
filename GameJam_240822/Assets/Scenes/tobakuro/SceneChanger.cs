using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadSceneA()
    {
        SceneManager.LoadScene("TopSelect");
        GManager.instance.select1 = "cabbage";

    }

    public void LoadSceneB()
    {
        SceneManager.LoadScene("TopSelect");
        GManager.instance.select1 = "onion";

    }

    public void LoadSceneC()
    {
        SceneManager.LoadScene("TopSelect");
        GManager.instance.select1 = "potato";

    }


}
