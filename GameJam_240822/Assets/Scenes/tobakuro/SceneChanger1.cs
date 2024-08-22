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
        SceneManager.LoadScene("SceneB");
        GManager.instance.select2 = 1;

    }

    public void LoadSceneB()
    {
        SceneManager.LoadScene("SceneB");
        GManager.instance.select2 = 2;

    }

    public void LoadSceneC()
    {
        SceneManager.LoadScene("SceneB");
        GManager.instance.select2 = 3;

    }


}
