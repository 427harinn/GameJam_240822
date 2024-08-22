using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger1 : MonoBehaviour
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
        SceneManager.LoadScene("Result");
        GManager.instance.select2 = "radish";

    }

    public void LoadSceneB()
    {
        SceneManager.LoadScene("Result");
        GManager.instance.select2 = "cucumber";
    }

    public void LoadSceneC()
    {
        SceneManager.LoadScene("Result");
        GManager.instance.select2 = "carrot";

    }


}
